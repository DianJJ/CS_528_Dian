using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera cam; // Allow setting a specific camera in the Inspector

    void Update()
    {
        if (cam != null) // Check if a camera is assigned
        {
            // Make the GameObject face towards the camera.
            transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward,
                             cam.transform.rotation * Vector3.up);
        }
        else
        {
            // Fallback to using the main camera if no specific camera is assigned
            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
                             Camera.main.transform.rotation * Vector3.up);
        }
    }
}