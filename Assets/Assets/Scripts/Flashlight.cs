using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight_ground,
        int_icon,
        flashlight_player,
        spotlight;

    private bool isNearFlashlight;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isNearFlashlight = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isNearFlashlight = false;
            if (int_icon.activeSelf == true)
                int_icon.SetActive(false);
        }
    }

    private void Update()
    {
        if (isNearFlashlight == true)
        {
            if (int_icon.activeSelf == false)
                int_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashlight_ground.SetActive(false);
                flashlight_player.SetActive(true);
                int_icon.SetActive(false);
            }
        }

        if (flashlight_player.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                Debug.Log("Called");
                if (spotlight.activeSelf == false)
                {
                    spotlight.SetActive(true);
                }
                else
                {
                    spotlight.SetActive(true);
                }
            }
        }
    }
}
