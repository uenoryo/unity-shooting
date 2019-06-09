using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyarea : MonoBehaviour
{
    void OnTriggerExit2D (Collider2D c)
    {
        Destroy (c.gameObject);
    }
}
