using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool mausTasteGedrückt = Input.GetMouseButtonDown(0);

        if (mausTasteGedrückt) {

            Vector3 vectorVonKameraZuBuch = transform.position - mainCamera.transform.position;

            float winkel = Vector3.Dot(vectorVonKameraZuBuch.normalized, mainCamera.transform.forward.normalized);
            if (winkel > 0.98) {
                gameObject.GetComponent<Rigidbody>()
                    .AddForce(
                    new Vector3(Random.Range(-100f, 100f)
                    , Random.Range(-100f, 100f)
                    , Random.Range(-1000f, 0f)));
            }

        }
    }
}
