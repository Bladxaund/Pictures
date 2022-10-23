using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody2D _rb;
   
    public void OpenDoor()
    {
        Debug.Log(message: "OPEN");
        _rb.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
    }
}
