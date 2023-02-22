using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText, lockText;
    public AudioSource open, close;
    public bool opened, locked;
    public static bool key_held;

    private bool isAtDoor, isDoorUsed;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            isAtDoor = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (intText.activeSelf)
            {
                intText.SetActive(false);
            }
            if (lockText.activeSelf)
            {
                lockText.SetActive(false);
            }
            isAtDoor = false;
            // close.play();
        }
    }

    IEnumerator repeat()
    {
        yield return new WaitForSeconds(0.5f);
        if (isDoorUsed) isDoorUsed = false;
    }

    private void InteractDoors()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isDoorUsed)
            {
                if (!opened)
                {
                    opened = true;
                    door_closed.SetActive(false);
                    door_opened.SetActive(true);
                    intText.SetActive(false);
                    isAtDoor = false;
                    // open.play();
                }
                else
                {
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

    void Update()
    {
        if (isAtDoor == true)
        {
            if (locked == false)
            {
                if (intText.activeSelf == false) intText.SetActive(true);
                InteractDoors();
            }
            if (locked == true)
            {
                if (key_held == false)
                {
                    if (lockText.activeSelf == false) lockText.SetActive(true);
                }
                else
                {
                    if (intText.activeSelf == false) intText.SetActive(true);
                    InteractDoors();
                }
            }
        }
    }
}
