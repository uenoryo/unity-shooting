using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;

    // Update ...
    void Update()
    {
        float x = Input.GetAxisRaw ("Horizontal");
        float y = Input.GetAxisRaw ("Vertical");

        Vector2 direction = new Vector2 (x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
