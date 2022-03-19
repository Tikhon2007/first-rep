using UnityEngine;

public class chanks : MonoBehaviour
{
    public Transform player;
    public float aabbccd;
    public Vector3 vpered;

    
    void FixedUpdate()
    {
        if(player.position.z-aabbccd>transform.position.z){
            transform.position = transform.position+vpered;
        }
    }
}
