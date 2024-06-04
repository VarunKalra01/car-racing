using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    public float horizontalFollowMultiplier = 0.3f;

    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    private void FixedUpdate()
    {
        if (player == null) return;

        
        Vector3 desiredPosition = player.position + offset + player.right * Input.GetAxis("Horizontal") * horizontalFollowMultiplier;

        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        
        transform.position = smoothedPosition;
    }
}
