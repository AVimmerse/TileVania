using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    [SerializeField] private float bulletSpeed = 20f;
    PlayerMovement player;
    private float xSpeed;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed; //the directiton of the player, 
                                                              //based on local scale, x by bullet speed
    }

    void Update()
    {
        myRigidBody.velocity = new Vector2(xSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject); //destroy the 'other' thing that collided, 
                                       //in this case the Enemy as that is the tag
        }
        Destroy(gameObject);        //destroys the bullet. or destroys me.
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

}
