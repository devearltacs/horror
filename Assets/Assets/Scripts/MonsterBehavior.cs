using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : MonoBehaviour
{
    public Rigidbody monster_rb;
    public Transform monster_trans,
        player_trans;
    public float monster_ms = 7.5f;

    private void FixedUpdate()
    {
        monster_rb.velocity = transform.forward * monster_ms * Time.deltaTime;
    }

    private void Update()
    {
        monster_trans.LookAt(player_trans);
    }
}
