using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    private Vector3 _cameraOffset = new Vector3(30, 0, 10);

    void Start()
    {

    }

    void LateUpdate()
    {
        // Ensure camera position moves with player object
        transform.position = plane.transform.position + _cameraOffset;
    }
}
