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

    private void OnEnable()
    {
        _color = serializedObject.FindProperty("_color");
        _duration = serializedObject.FindProperty("_duration");
        _speed = serializedObject.FindProperty("_speed");
    }

}
    
