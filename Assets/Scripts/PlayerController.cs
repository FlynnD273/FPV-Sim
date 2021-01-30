using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool LinkRollPitch;

    public float RollRate;
    public float RollSuper;
    public float RollExpo;

    public float PitchRate;
    public float PitchSuper;
    public float PitchExpo;

    public float YawRate;
    public float YawSuper;
    public float YawExpo;

    public float ThrottleRate;
    public float ThrottleExpo;
    public float ThrottleMid;
    public float ThrottleMin;


    private PlayerInput input;
    private Vector2 stickLeft = new Vector2();
    private Vector2 stickRight= new Vector2();
    private Rigidbody rb;


    private void Awake()
    {
        input = new PlayerInput();

        input.Gameplay.StickRightX.performed += c => stickRight.x = c.ReadValue<float>();
        input.Gameplay.StickRightX.canceled += c => stickRight.x = 0;

        input.Gameplay.StickRightY.performed += c => stickRight.y = c.ReadValue<float>();
        input.Gameplay.StickRightY.canceled += c => stickRight.y = 0;


        input.Gameplay.StickLeftX.performed += c => stickLeft.x = c.ReadValue<float>();
        input.Gameplay.StickLeftX.canceled += c => stickLeft.x = 0;

        input.Gameplay.StickLeftY.performed += c => stickLeft.y = c.ReadValue<float>();
        input.Gameplay.StickLeftY.canceled += c => stickLeft.y = 0;

        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        input.Gameplay.Enable();
    }

    private void OnDisable()
    {
        input.Gameplay.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(
            GetRate(stickRight.y, PitchRate, PitchExpo, PitchSuper), 
            GetRate(stickLeft.x, YawRate, YawExpo, YawSuper), 
            GetRate(-stickRight.x, RollRate, RollExpo, RollSuper)) 
            * Time.deltaTime;

        //var r = transform.rotation;
        transform.Rotate(rotation, Space.Self);
        //var n = transform.rotation;
        //transform.rotation = r;
        //rb.MoveRotation(n);

        rb.AddForce(transform.up * GetThrottle(stickLeft.y, ThrottleRate, ThrottleMid, ThrottleExpo) * Time.deltaTime);
        //Debug.Log(Time.deltaTime);

        Debug.Log("Left: " + stickLeft);
        Debug.Log("Right: " + stickRight);
    }


    // BF rate calculation function
    float GetRate (float input, float rate, float expo, float super) 
    {
        float absRate = Mathf.Abs(input);

        if (rate > 2)
            rate = rate + (14.54f * (rate - 2));

        if (expo != 0)
            input = input * Mathf.Pow(absRate, 3) * expo + input * (1 - expo);

        float angleRate = 200 * rate * input;

        if(super != 0)
        {
            float superScale = 1 / Mathf.Clamp(1 - absRate * super, 0.01f, 1);
            angleRate *= superScale;
        }

        return angleRate;
    }

    float GetThrottle(float throttle, float throttleRate, float mid, float expo)
    {
        throttle -= ThrottleMin;
        throttle /= 1 - ThrottleMin;

        float r;
        if (throttle >= mid)
        {
            throttle = Mathf.Pow(throttle - mid, expo + 1) + mid;
            throttle /= Mathf.Pow(1 - mid, expo + 1) + mid;
            return throttle * throttleRate;
        }
        else
        {
            throttle = Mathf.Pow(mid, expo + 1) - Mathf.Pow(mid - throttle, expo + 1);
            throttle /= Mathf.Pow(1 - mid, expo + 1) + mid;
            throttle /= Mathf.Pow(mid, expo);
            return throttle * throttleRate;
        }
    }
}
