using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Particle", fileName = "P_")]
public class ParticlesData : ScriptableObject
{
    //stuff we want to customize for this 
    // Color
    // Duration 
    // Burst 
    // Speed 

   
    [SerializeField] private float _duration = 3f;
    [SerializeField] private float _speed = 0.3f;
    
    public float Duration => _duration;
    public float Speed => _speed;

}
