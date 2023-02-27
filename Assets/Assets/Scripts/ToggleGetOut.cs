using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGetOut : MonoBehaviour
{
    public GameObject out_text;
    
    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")) {
            if(out_text.activeSelf == false) out_text.SetActive(true);
        }
    }
}
