using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float turnSpeed = 0f;
    public float horizontalInput;
    public float verticallInput;

    void Start()
    {
        
    }

    void Update()
    {
        // Allow user to control acceleration
        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticallInput);

        // Allow the user to turn the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
