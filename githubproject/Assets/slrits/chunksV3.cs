using UnityEngine;

public class chunksV3 : MonoBehaviour
{
    public Transform chunk1;
    public Transform chunk2;
    public Transform chunk3;
    public float aabbccd = 40;
    public float aabb = 120;

    public Vector3 vpered;
    

    void FixedUpdate()
    {
       
        if(transform.position.z -aabbccd > chunk1.position.z){
            Destroy(chunk1);
            Vector3 spawnPosition = new Vector3(0, 0, transform.position.z + 120);
            Instantiate(chunk1, spawnPosition, Quaternion.identity);
        }
        if(transform.position.z -aabbccd > chunk2.position.z){
            Destroy(chunk2);
            Vector3 spawnPosition = new Vector3(0, 0, transform.position.z + 120);
            Instantiate(chunk2, spawnPosition, Quaternion.identity);
        }
        if(transform.position.z -aabbccd > chunk3.position.z){
            Destroy(chunk3);
            Vector3 spawnPosition = new Vector3(0, 0, transform.position.z + 120);
            Instantiate(chunk3, spawnPosition, Quaternion.identity);
        }

    }
}
