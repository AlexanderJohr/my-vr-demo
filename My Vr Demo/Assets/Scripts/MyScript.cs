using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        this.enabled = false;
    }
}
