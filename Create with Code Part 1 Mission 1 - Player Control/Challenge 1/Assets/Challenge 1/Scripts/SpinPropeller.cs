using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float _propellerSpeed = 1000f;
    void Start()
    {

    }

    void Update()
    {
        // Make the propeller spin at a constant speed
        transform.Rotate(Vector3.forward * Time.deltaTime * _propellerSpeed);
    }
}
