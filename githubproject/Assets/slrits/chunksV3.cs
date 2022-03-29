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
        if(transform.position.z % 10 == 0){
            int random = Random.Range(1,3);
            if(random == 1){
                Vector3 spawnPosition = new Vector3(0, 0, transform.position.z + aabb);
                Instantiate(chunk1, spawnPosition, Quaternion.identity);
            }
            if(random == 2){
                Vector3 spawnPosition = new Vector3(0, 0, transform.position.z + aabb);
                Instantiate(chunk2, spawnPosition, Quaternion.identity);
            }
            if(random == 3){
                Vector3 spawnPosition = new Vector3(0, 0, transform.position.z + aabb);
                Instantiate(chunk3, spawnPosition, Quaternion.identity);
            }
        }
    }
}
