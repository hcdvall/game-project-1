using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContoller : MonoBehaviour
{
    
    enum LookingDir
    {
        Up,
        Down,
        Left,
        Right
        
    }


    [SerializeField]private float jumpforce = 1f;
    private Rigidbody2D _body;
    [SerializeField]private float movementSpeed = 3f;
    private void Update()
    {
        float movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (Input.GetButton("Jump") && Mathf.Abs(_body.velocity.y) <3f)
        {
            _body.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }
    }

    

    private void FixedUpdate()
    {
        
    }

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }
}
