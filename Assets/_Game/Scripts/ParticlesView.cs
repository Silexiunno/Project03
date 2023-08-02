using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesView : MonoBehaviour
{
    [SerializeField] public ParticleSystem ThisObject;
    


    public void Display(ParticlesData data)
    {
        var main = ThisObject.main;
        main.startLifetime = data.Duration;
      
    }

    
}
// need to make the start color random between color one and two 