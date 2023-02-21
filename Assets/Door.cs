using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText;
    public AudioSource open, close;
    public bool opened;

    private bool isAtDoor, isDoorUsed;

    void OnTriggerStay(Collider other) {
        if(other.CompareTag("MainCamera")) {
            isAtDoor = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.CompareTag("MainCamera")) {
            intText.SetActive(false);
            isAtDoor = false;
            // close.play();
        }
    }

    IEnumerator repeat() {
        yield return new WaitForSeconds(1.0f);
        if(isDoorUsed) isDoorUsed = false;
    }

    void Update () {
        if (isAtDoor == true) {
            intText.SetActive(true);
            if(!isDoorUsed) {
                if(Input.GetKeyDown(KeyCode.F)) {
                    if(!opened) {
                        opened = true;
                        door_closed.SetActive(false);
                        door_opened.SetActive(true);
                        intText.SetActive(false);
                        isAtDoor = false;
                        // open.play();
                    } else {
                        opened = false;
                        door_closed.SetActive(true);
                        door_opened.SetActive(false);
                        intText.SetActive(false);
                        isAtDoor = false;
                        // close.play();
                    }
                    isDoorUsed = true;
                    StartCoroutine(repeat());
                }
            }
        }
    }
}
