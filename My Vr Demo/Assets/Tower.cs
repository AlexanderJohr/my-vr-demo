using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(this.transform.localRotation.eulerAngles.x
                                                  , this.transform.localRotation.eulerAngles.y + 1
                                                  , this.transform.localRotation.eulerAngles.z);
    }
}
