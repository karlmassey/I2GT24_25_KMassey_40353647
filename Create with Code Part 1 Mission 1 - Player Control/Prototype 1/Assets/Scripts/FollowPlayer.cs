using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private Vector3 _cameraOffset = new Vector3();

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // Offset the cameras position
        transform.position = player.transform.position + _cameraOffset;
    }
}
