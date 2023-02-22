using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject int_icon, key;

    private bool key_near;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            key_near = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            key_near = false;
        }
    }

    private void Update()
    {
        if (key_near == true)
        {
            if (int_icon.activeSelf == false) int_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                key.SetActive(false);
                Door.key_held = true;
                int_icon.SetActive(false);
            }
        }
    }
}
