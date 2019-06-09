using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 10;

    // Update ...
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
    }
}
