using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerController))]
public class EditorPlayer : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        PlayerController script = target as PlayerController;

        if (script.LinkRollPitch)
        {
            script.PitchExpo = script.RollExpo;
            script.PitchRate = script.RollRate;
            script.PitchSuper = script.RollSuper;
        }
    }
}
