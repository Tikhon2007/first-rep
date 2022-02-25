using UnityEngine;

public class kameraplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    
    void FixedUpdate()
    {
        transform.position = player.position + offset;

    }
}
