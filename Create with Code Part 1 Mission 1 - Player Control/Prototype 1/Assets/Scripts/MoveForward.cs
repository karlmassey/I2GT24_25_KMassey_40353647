using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 30f;
    private Transform myTransform;

    void Start()
    {
        // Caching variables
        myTransform = transform;
    }

    void Update()
    {
        // Make vehicles drive towards player
        myTransform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
