using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    public GameObject topViewCamera;
    public GameObject frontViewCamera;

    [SerializeField]
    private KeyCode _toggleKey;

    private void Update()
    {
        // Check if the appropriate key is pressed
        if (Input.GetKeyDown(_toggleKey))
        {
            ToggleCameraView();
        }
    }

    private void ToggleCameraView()
    {

        // topViewCamera.SetActive(!topViewCamera.activeSelf);
        // frontViewCamera.SetActive(!frontViewCamera.activeSelf);

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
