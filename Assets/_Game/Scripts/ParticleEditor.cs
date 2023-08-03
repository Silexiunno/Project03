using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Particle))]

public class ParticleEditor : Editor
{
    SerializedObject Particle;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.Space(10);

       if(GUILayout.Button("Apply Variables"))
        {
        //  Particle.FindProperty(int T){

            
        }

        
    }

   
}



