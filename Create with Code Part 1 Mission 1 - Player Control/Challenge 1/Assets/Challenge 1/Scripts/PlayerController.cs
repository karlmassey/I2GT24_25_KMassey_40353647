using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 15f;
    private float _rotationSpeed = 100f;
    private float _verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // Tilt the plane up/down based on up/down arrow keys
        _verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * Time.deltaTime * _rotationSpeed * _verticalInput);

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);

       
    }
}
