using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractOnGaze : MonoBehaviour
{
    private bool schaueBereitsDrauf;

    [SerializeField]
    private float winkelToleranz;

    [SerializeField]
    private ParticleSystem particleSystemGameObject; 

    void Start()
    {
        
    }

    void Update()
    {
        var a = Camera.main.transform.position;
        var b = transform.position;

        var ab = b - a;
        var abn = ab.normalized;

        var ctf = Camera.main.transform.forward;

        // -1 = Entgegengesetzt
        //  0 = senkrecht aufeinander
        //  1 = gleiche Richtung
        var winkel = Vector3.Dot(ctf, abn); // -1 ... 0 ... 0.9 ... 1 


        // z.B.  wT = 0.1    1-wT=0.9    w> 0.9                 ⬇   ↔   ⬇
        //                                         -1 ... 0 ... 0.9 ... 1     
        bool schaueGeradeDrauf = winkel > (1 - winkelToleranz);

         

        if (!schaueBereitsDrauf && schaueGeradeDrauf)
        {
            schaueBereitsDrauf = true;

            AktiviereEffekt();
        }
        else if (schaueBereitsDrauf && !schaueGeradeDrauf) {
            schaueBereitsDrauf = false;

            DeaktiviereEffekt();
        }
 
    }

    private void DeaktiviereEffekt()
    {
        particleSystemGameObject.Stop();
    }

    private void AktiviereEffekt()
    {
        particleSystemGameObject.Play();
    }
}
