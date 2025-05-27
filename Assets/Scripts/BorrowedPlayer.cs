using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrowedPlayer : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10f;
    public Vector2 direction;
    private bool facingRight = true;

    [Header("Components")]
    public Rigidbody2D rb;
    public Animator animator;

    [Header("Physics")]
    public float maxSpeed = 7f;
    public float linearDrag = 4f;

    void Start()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void Update()
    {
        
    }
}
