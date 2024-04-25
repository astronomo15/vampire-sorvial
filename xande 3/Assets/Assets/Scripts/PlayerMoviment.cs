using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public PlayerMoviment instance;
    Rigidbody2D body;
    public float speed = 5;
    float horizontal;
    float vertical;

    public Transform weapon;
    public static Transform posPlayer;
    float direction;
    void Start()
    {
        instance = this;
        posPlayer = transform;
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0) 
        {
            direction = horizontal;
        }
        weapon.localScale = new Vector2 (direction, weapon.localScale.y);
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
