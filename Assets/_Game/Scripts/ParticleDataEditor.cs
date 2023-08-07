using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(ParticlesData))]
public class ParticleDataEditor : Editor
{
    private SerializedProperty _color;
    private SerializedProperty _duration;
    private SerializedProperty _speed;
    private SerializedProperty _playonawake;
    private SerializedProperty _startMax;
    private SerializedProperty _startMin;
    private SerializedProperty _particlename;
    private SerializedProperty _default;

    //Color matColor = Color.white;


    public void OnEnable()
    {
        _color = serializedObject.FindProperty("_color");
        _duration = serializedObject.FindProperty("_duration");
        _speed = serializedObject.FindProperty("_speed");
        _playonawake = serializedObject.FindProperty("_playonawake");
        _startMax = serializedObject.FindProperty("_startMax");
        _startMin = serializedObject.FindProperty("_startMin");
        _particlename = serializedObject.FindProperty("_particlename");
        _default = serializedObject.FindProperty("_default");

     }


    public override void OnInspectorGUI()
    {
        //  base.OnInspectorGUI();
        EditorGUILayout.LabelField("Default Particle", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_default, new GUIContent("Particle Prefab", "Place default particle here please!"));
        EditorGUILayout.Space(15);


        EditorGUILayout.LabelField("General Stats", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_particlename, new GUIContent("Name"));
        if (_particlename.stringValue == string.Empty)
        {
            EditorGUILayout.HelpBox
                ("Please give the Particle a name",
                MessageType.Warning);
        }
      

      //  matColor = EditorGUILayout.ColorField("New Color", matColor);



        EditorGUILayout.Space(15);
        ParticlesData data = (ParticlesData)target;
        if (GUILayout.Button("Create"))
        {
            data.Create();

        }
    }
   
    
   
    
}
    
