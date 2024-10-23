using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour
{
    Rigidbody2D bulletRigidbody2D;
    float bulletSpeed = 10;
    float xSpeed;
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody2D = GetComponent<Rigidbody2D>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        xSpeed = playerMovement.transform.localScale.x * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidbody2D.velocity = new Vector2(xSpeed, 0);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            Destroy(collider.gameObject);
        }
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        Destroy(gameObject);
    }
}
