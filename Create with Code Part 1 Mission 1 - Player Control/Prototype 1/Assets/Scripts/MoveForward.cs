using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 30f;

    void Start()
    {
        
    }

    void Update()
    {
        // Make vehicles drive towards player
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
