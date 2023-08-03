using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Particle : MonoBehaviour
{
    [SerializeField] public ParticlesData Data;
    [SerializeField] private ParticleSystem _thisPS;

    void OnEditorGUI()
    {

    }
  public void ApplyStats()
    {
        Display(Data);
    }
    public void Display(ParticlesData data)
    {
        var main = _thisPS.main;
        main.startLifetime = data.Duration;

    }
    

}
