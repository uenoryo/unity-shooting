using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Spaceship spaceship;

    // Start is called before the first frame update
    void Start()
    {
        spaceship = GetComponent<Spaceship> ();

        spaceship.Move (transform.up * -1);
    }
}
