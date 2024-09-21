using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20f;
    private float _turnSpeed = 45f;

    public string inputID;
    private float _horizontalInput;
    private float _verticalInput;

    void Start()
    {
        
    }

    void Update()
    {
        // Allow user to control acceleration using vertical input
        _verticalInput = Input.GetAxis("Vertical" + inputID);
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);

        // Allow the user to turn the vehicle using horizontal input
        _horizontalInput = Input.GetAxis("Horizontal"+ inputID);
        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
    }
}
