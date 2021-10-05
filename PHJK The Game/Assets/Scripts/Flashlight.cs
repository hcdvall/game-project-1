using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    
    
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] float offset = 0f;
    private Camera cam;
    public int health = 2;

    private Vector2 movement;
    private Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lokDir = mousePos - rigidBody.position;
        float angle = Mathf.Atan2(lokDir.y, lokDir.x) * Mathf.Rad2Deg + offset;
        rigidBody.rotation = angle;  
    }

    private void Awake()
    {
        cam = Camera.main;
    }
}
