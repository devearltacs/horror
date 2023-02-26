using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlashlight : MonoBehaviour
{
    public GameObject spotlight;

    // Update is called once per frame
    void Update()
    {
        if (spotlight.activeSelf == true) {
            if(Input.GetMouseButtonDown(0)) {
               Light light = spotlight.GetComponent<Light>();
               light.enabled = !light.enabled;
            }
        }
    }
}
