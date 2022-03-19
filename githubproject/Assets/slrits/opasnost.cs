using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opasnost : MonoBehaviour
{
public Transform player;
public Transform chank;
    void Update()
    {
        
        if(player.position.z % 10f == 0f)
        {
            Vector3 spawnPosition = new Vector3(0, 1, player.position.z + 20);
            Instantiate(chank, spawnPosition, Quaternion.identity);
        }

    }

}