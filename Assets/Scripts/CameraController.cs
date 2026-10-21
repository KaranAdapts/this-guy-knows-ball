using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        // calculates the distance between the player and camera 
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // rebuilds the camera's position from scratch every frame 
        transform.position = player.transform.position + offset; 
    }
}
