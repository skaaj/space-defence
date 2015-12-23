using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float paneSpeed = 1.0f;
    public float scrollSpeed = 4.0f;

    void Start () {
	
	}
	
	void Update () {
        float horizontal = Input.GetAxis("Horizontal") * paneSpeed;
        float vertical = Input.GetAxis("Vertical") * paneSpeed;
        float zoom = Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;

        // Handle Camera Movement
        Vector3 movement = new Vector3(horizontal, vertical, 0.0f);
        transform.Translate(movement);

        // Handle Camera Zoom
        Camera mainCamera = Camera.main;
        mainCamera.orthographicSize += zoom;
        if (mainCamera.orthographicSize < 5)
            mainCamera.orthographicSize = 5;
    }
}
