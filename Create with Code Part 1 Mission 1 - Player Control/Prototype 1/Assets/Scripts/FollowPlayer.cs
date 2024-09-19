using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 _cameraOffset = new Vector3(0, 9, -8);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // Offset the cameras position to be behind the player
        transform.position = player.transform.position + _cameraOffset;
    }
}
