using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Particle", fileName = "P_")]
public class ParticlesData : ScriptableObject
{
  
    [SerializeField] private float _duration = 3f;
    [SerializeField] private float _speed = 0.3f;
    [SerializeField] private float _startMax;
    [SerializeField] private float _startMin;
    [SerializeField] private string _particlename;

    [SerializeField] public ParticleSystem _default;
   



    public void Create()
    {
        InstantiatePrefab(_default);
    }
    public void InstantiatePrefab(ParticleSystem P_Default)
    {
        ParticleSystem newsystem = Instantiate(P_Default);
        newsystem.gameObject.name = _particlename;
        var newMainsystem = newsystem.main;
        newMainsystem.startSpeed = _speed;
        newMainsystem.duration = _duration;
        newMainsystem.startSize = Random.Range(_startMin, _startMax);


    }

    public float Duration => _duration;
    public float Speed => _speed;
    public float StartMax => _startMax;
    public float StartMin => _startMin;
    public string ParticleName => _particlename;
    
}
