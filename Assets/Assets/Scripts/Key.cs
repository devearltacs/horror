using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject int_icon, key, kitchenlight;
    public GameObject outsidelight, entrance_door, hurt_text;
    public GameObject monster;
    public AudioSource ambience_player, monster_roar;

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
            int_icon.SetActive(false);
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
                kitchenlight.GetComponent<Light>().enabled = false;
                outsidelight.GetComponent<Light>().enabled = false;
                hurt_text.SetActive(true);
                monster.SetActive(true);
                key.SetActive(false);
                Door.key_held = true;
                int_icon.SetActive(false);
                ambience_player.Stop();
                monster_roar.Play();
            }
        }
    }
}
