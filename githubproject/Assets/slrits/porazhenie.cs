using UnityEngine;

public class porazhenie : MonoBehaviour
{
    public movement movement;
    void OnCollisionEnter(Collision collisioninfo)
    {
        //Debug.Log (collisioninfo.collider.name);
        if (collisioninfo.collider.tag == "dangerous")
        {
            Debug.Log("opa");
            movement.enabled = false;
        }
    }
}
