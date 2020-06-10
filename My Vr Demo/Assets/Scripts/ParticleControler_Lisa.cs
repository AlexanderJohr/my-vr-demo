using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControler_Lisa : MonoBehaviour
{
    ParticleSystem ps; //Attribut oder Feld

    // Start is called before the first frame update
    void Start()
    {
        //componenten holen, die wir im weiteren Verlauf benötigen
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        bool mousebuttonIsClicked = Input.GetMouseButtonDown(0);

        if (mousebuttonIsClicked)
        {
            ps.Play();
        }
        
    }
}
