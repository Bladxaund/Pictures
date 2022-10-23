using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private KeyCode _openDoorKey;
    [SerializeField] private LayerMask _doorLayerMask;
    private Collider2D currTriggerCol;
    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
            Move();


        if (Input.GetKeyDown(_openDoorKey)) 
            OpenDoor();
        
    }
    private void Move()
    {
        _rb.velocity = Vector2.right * _speed * Input.GetAxis("Horizontal");
    }

    private void OpenDoor()
    {
       
        if (currTriggerCol != null)
        {       
            Door doorComponent = currTriggerCol.gameObject.GetComponent<Door>();
            Debug.Log(doorComponent);
            doorComponent.OpenDoor();
        }     
    }

   private void OnTriggerEnter2D(Collider2D col)
    {
        if ((_doorLayerMask.value & (1 << col.gameObject.layer)) > 0)       
        {
            Debug.Log(message: "ON TRIGGER  ENTER");
            currTriggerCol = col;
        }
    }

    private void OnCollisionExist2D(Collision2D other)
    {
        currTriggerCol = null;
    }

    
}



   

