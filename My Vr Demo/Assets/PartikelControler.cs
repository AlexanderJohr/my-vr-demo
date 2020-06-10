using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartikelControler : MonoBehaviour
{
    ParticleSystem ps; // Feld oder Attribut

    void Start()
    {
        

        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {


        



        bool maustasteWurdeGedrückt = Input.GetMouseButtonDown(0);

        if (maustasteWurdeGedrückt) {

            // Bit shift the index of the layer (8) to get a bit mask
            int layerMask = 1 << 8;

            RaycastHit hit;

            bool wurdeGetroffen = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity, layerMask);

            if (wurdeGetroffen)
            {
                ps.Play();
            }
            else
            {
                
            }





            
        }

    }
}
