using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPick : MonoBehaviour
{
    int pointsAvailable = 100;
    [SerializeField] AudioClip coinClip;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            FindObjectOfType<GameSession>().AddScore(pointsAvailable);
            AudioSource.PlayClipAtPoint(coinClip, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
