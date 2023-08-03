using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Events;
using UnityEditor;
[ExecuteInEditMode]

public class ParticlesView : MonoBehaviour
{
    [SerializeField] public ParticleSystem ThisObject;
    [SerializeField] private ParticlesData _data01;


    public void Display(ParticlesData data)
    {
        var main = ThisObject.main;
        main.startLifetime = data.Duration;
      
    }

    //EditorGUILayout.Button("Update");
    
}
// need to make the start color random between color one and two 