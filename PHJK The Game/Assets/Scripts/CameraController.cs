using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    private Camera _camera;

    // Update is called once per frame
    void Update()
    {

        if (playerTransform.position.y > 0f)
        {
            transform.position = new Vector3(transform.position.x, playerTransform.position.y, -10f); 
        }
        else if (playerTransform.position.y < 0f)
        {
            transform.position = new Vector3(transform.position.x, 0, -10f);
        }

        
    }

    private void Awake()
    {
        _camera = Camera.main;
    }
}
