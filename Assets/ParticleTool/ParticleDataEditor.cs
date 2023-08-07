using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(ParticlesData))]
public class ParticleDataEditor : Editor
{
    private SerializedProperty _duration;
    private SerializedProperty _speed;
    private SerializedProperty _startMax;
    private SerializedProperty _startMin;
    private SerializedProperty _particlename;
    private SerializedProperty _default;

   

    public void OnEnable()
    {
        
        _duration = serializedObject.FindProperty("_duration");
        _speed = serializedObject.FindProperty("_speed");
        _startMax = serializedObject.FindProperty("_startMax");
        _startMin = serializedObject.FindProperty("_startMin");
        _particlename = serializedObject.FindProperty("_particlename");
        _default = serializedObject.FindProperty("_default");
        
     }


    public override void OnInspectorGUI()
    {
        serializedObject.UpdateIfRequiredOrScript();
    
        EditorGUILayout.LabelField("Default Particle", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_default, new GUIContent("Particle Prefab", "Place default particle here please!"));
        EditorGUILayout.Space(15);


        EditorGUILayout.LabelField("General Stats", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_particlename, new GUIContent("Name"));
        if (_particlename.stringValue == string.Empty)
        {
            EditorGUILayout.HelpBox
                ("Please give the Particle a name", MessageType.Warning);
        }

        // gave up on color 

        EditorGUILayout.PropertyField(_duration, new GUIContent("Duration", "Duration of particle effect"));
        if (_duration.floatValue <= 0)
        {
            EditorGUILayout.HelpBox( "Duration should at least be greater than 0", MessageType.Warning);
        }

        EditorGUILayout.BeginHorizontal();
        EditorGUIUtility.labelWidth = 1;
        EditorGUILayout.LabelField("Start Speed of Particle");
        _speed.floatValue = EditorGUILayout.Slider
            (_speed.floatValue, 0, 5);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUIUtility.labelWidth = 1;
        EditorGUILayout.LabelField("Minimum Particle Size");
        _startMin.doubleValue = EditorGUILayout.Slider
           (_startMin.floatValue, 0.001f, 0.03f);
        EditorGUILayout.EndHorizontal();
        
        EditorGUILayout.BeginHorizontal();
        EditorGUIUtility.labelWidth = 1;
        EditorGUILayout.LabelField("Maximum Particle Size");
        _startMax.doubleValue = EditorGUILayout.Slider
         (_startMax.floatValue, 0.035f, 0.09f);
        EditorGUILayout.EndHorizontal();
      



        EditorGUILayout.Space(15);
        ParticlesData data = (ParticlesData)target;
        if (GUILayout.Button("Create"))
        {
            data.Create();

        }


        serializedObject.ApplyModifiedProperties();
    }


    


}
    
