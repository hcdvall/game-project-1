using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    
    
    [SerializeField] Rigidbody2D rigidBody;
    private Transform playerTransform;
    [SerializeField] float offset = 0f;
    private Camera cam;
    public int batteryLife = 100;
    

    private Vector2 movement;
    private Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2") && batteryLife < 0)
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lokDir = mousePos - rigidBody.position;
            float angle = Mathf.Atan2(lokDir.y, lokDir.x) * Mathf.Rad2Deg + offset;
            rigidBody.rotation = angle;
            
        }
        else
        {
            die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        cam = Camera.main;
        playerTransform = transform.parent;
        rigidBody = playerTransform.GetComponent<Rigidbody2D>();
    }
}
