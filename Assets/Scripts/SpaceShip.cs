﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour
{
    public float speed;

    public float shotDelay;

    public bool canShot;

    public GameObject bullet;

    public GameObject explosion;

    public void Explosion ()
    {
        Instantiate (explosion, transform.position, transform.rotation);
    }


    public void Shot (Transform origin)
    {
        Instantiate (bullet, origin.position, origin.rotation);
    }

    public void Move (Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
