using UnityEngine;

public class chunks : MonoBehaviour
{
    public float aabbcc = 40;
    public float aabb = 120;
    public Vector3 vpered;

    void FixedUpdate()
    {
        if (GameObject.FindWithTag("chunk"))
        {
            if (transform.position.z + aabbcc> GameObject.FindWithTag("chunk").transform.position.z)
            {
                Destroy(GameObject.FindWithTag("chunk"));
            }
        }


    }
}
