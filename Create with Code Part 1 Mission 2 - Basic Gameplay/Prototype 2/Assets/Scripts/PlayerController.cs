using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    private float _speed = 10.0f;
    private float _xRange = 20f;

    private float _minZ = -1f;
    private float _maxZ = 15.5f;

    public GameObject projectilePrefab;


    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * _speed);

        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }


        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * _speed);

        if (transform.position.z < _minZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
            _minZ);
        }
        if (transform.position.z > _maxZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
            _maxZ);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
