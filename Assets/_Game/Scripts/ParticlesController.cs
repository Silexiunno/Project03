using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Events;
public class ParticlesController : MonoBehaviour
{
    [SerializeField] private ParticlesView _particleview;
    [SerializeField] private ParticlesData _data01;

    //Event bu
    private void Start()
    {
        _particleview.Display(_data01);
    }
    
}
