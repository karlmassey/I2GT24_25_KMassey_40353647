using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    public GameObject topViewCamera;
    public GameObject frontViewCamera;

    private void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCameraView();
        }
    }

    private void ToggleCameraView()
    {
        if (topViewCamera.activeSelf)
        {
            topViewCamera.SetActive(false);
            frontViewCamera.SetActive(true);
        }
        else if (frontViewCamera.activeSelf) 
        {
            topViewCamera.SetActive(true);
            frontViewCamera.SetActive(false);
        }
    }
}
