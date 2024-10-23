using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float moveSpeed = 1f;
    Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rigidBody.velocity = new Vector2(moveSpeed, 0);
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        moveSpeed = -moveSpeed;
        FlipEnemy();
    }
    void FlipEnemy()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rigidBody.velocity.x)), 1f);
    }
}
