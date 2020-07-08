using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SaturateOnSpacePress : MonoBehaviour
{
    PostProcessVolume postProcessVolume;
    ColorGrading colorGrading;

    private bool saturation;

    public bool Saturation
    {
        get { return saturation; }
        set {
            saturation = value;

            if (saturation)
            {
                colorGrading.saturation.value = 0;
            }
            else {
                colorGrading.saturation.value = -100;
            }
        }
    }



    void Start()
    {
        postProcessVolume = FindObjectOfType<PostProcessVolume>();

        
        postProcessVolume.profile.TryGetSettings<ColorGrading>(out colorGrading);
    }

    // Update is called once per frame
    void Update()
    {


        bool spaceIsPressed = Input.GetKeyDown(KeyCode.Space);


        if (spaceIsPressed) {
            Saturation = !Saturation;
        }
    }
}
