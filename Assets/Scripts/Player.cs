using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Spaceship spaceship;

    public GameObject bullet;

    // Startメソッドをコルーチンとして呼び出す
    IEnumerator Start ()
    {
        this.spaceship = GetComponent<Spaceship> ();

        while (true) {
            this.spaceship.Shot (transform);

            yield return new WaitForSeconds (this.spaceship.shotDelay);
        }
    }

    // Update ...
    void Update()
    {
        float x = Input.GetAxisRaw ("Horizontal");
        float y = Input.GetAxisRaw ("Vertical");

        Vector2 direction = new Vector2 (x, y).normalized;
        this.spaceship.Move (direction);
    }

    void OnTriggerEnter2D (Collider2D c)
    {
        string layerName = LayerMask.LayerToName(c.gameObject.layer);

        if( layerName == "Bullet (Enemy)")
        {
            Destroy(c.gameObject);
        }

        if( layerName == "Bullet (Enemy)" || layerName == "Enemy")
        {
            spaceship.Explosion();
            Destroy (gameObject);
        }
    }
}
