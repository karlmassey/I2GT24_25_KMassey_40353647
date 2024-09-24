using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerToggle : MonoBehaviour
{
    [SerializeField]
    private KeyCode _toggleKey;

    public GameObject player1TopViewCamera;
    public GameObject player1FrontViewCamera;

    public GameObject player2;
    public GameObject player2CameraManager;
    public GameObject player2TopViewCamera;
    public GameObject player2FrontViewCamera;

    private void Update()
    {
        // Check if the appropriate key is pressed
        if (Input.GetKeyDown(_toggleKey))
        {
            ToggleMultiplayer();
        }
    }

    private void ToggleMultiplayer()
    {
        if (player2.activeSelf)
        {
            player2.SetActive(false);
            player2CameraManager.SetActive(false);

            AdjustCameraWidth(1f);
        }

        else if (!player2.activeSelf)
        {
            player2.SetActive(true);
            player2CameraManager.SetActive(true);

            AdjustCameraWidth(0.5f);
            SyncPlayerCameras();
        }
    }

    private void AdjustCameraWidth(float width)
    {
        player1FrontViewCamera.GetComponent<Camera>().rect = new Rect(0, 0, width, 1);
        player1TopViewCamera.GetComponent<Camera>().rect = new Rect(0, 0, width, 1);
    }

    private void SyncPlayerCameras()
    {
        player2FrontViewCamera.SetActive(player1FrontViewCamera.activeSelf);
        player2TopViewCamera.SetActive(player1TopViewCamera.activeSelf);
    }
}
