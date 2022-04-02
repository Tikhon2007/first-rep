using UnityEngine;

public class chunksV3 : MonoBehaviour
{
    public Transform chunk1;
    public Transform chunk2;
    public Transform chunk3;
    public float aabbccd = 25;
    public float aabb = 120;

    public Vector3 vpered;
    

    void FixedUpdate()
    {
       
        if(transform.position.z -aabbccd > chunk1.position.z){
            Vector3 spawnPosition = new Vector3(0, 1, transform.position.z + 120);
            Instantiate(chunk1, spawnPosition, Quaternion.identity);
        }
        if(transform.position.z -aabbccd > chunk2.position.z){
            Vector3 spawnPosition = new Vector3(0, 1, transform.position.z + 120);
            Instantiate(chunk2, spawnPosition, Quaternion.identity);
        }
        if(transform.position.z -aabbccd > chunk3.position.z){
            Vector3 spawnPosition = new Vector3(0, 1, transform.position.z + 120);
            Instantiate(chunk3, spawnPosition, Quaternion.identity);
        }

    }
}
