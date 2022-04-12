using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class chunks : MonoBehaviour
{
    public float otigroka = 40;
    public float spavn = 120;
    public Vector3 vpered ;
    public List<GameObject> chunk = new List<GameObject>();

    void FixedUpdate()
    {
        int randomNumber = Random.Range(0,chunk.Count);
        for(int i = 1; i < chunk.Count; i++){
            if(transform.position.z-otigroka>chunk[i].transform.position.z){
                Vector3 spawnPosition = new Vector3(vpered.x, vpered.y, transform.position.z + vpered.z);
                Instantiate(chunk[randomNumber], vpered, Quaternion.identity);
                
            }
        }

        
    }
}




