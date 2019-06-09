using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 10;

    public float lifeTime = 5;

    // Start ...
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        Destroy (gameObject, lifeTime);
    }
}
