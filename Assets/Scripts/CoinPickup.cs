using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    //private CircleCollider2D coinCollider;
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int pointsForCoinPickup = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
