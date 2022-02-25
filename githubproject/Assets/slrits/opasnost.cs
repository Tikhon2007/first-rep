using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opasnost : MonoBehaviour
{

    public GameObject Object;
    public Transform player;
    public Vector3 spavn;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(0, 1, player.position.z + 10);
        Instantiate(Object, spawnPosition, Quaternion.identity);
    }
    void FixedUpdate()
    {
        if (player.position.z < gameObject.transform.position.z)
        {
            Debug.Log("10000");
        }
    }

}