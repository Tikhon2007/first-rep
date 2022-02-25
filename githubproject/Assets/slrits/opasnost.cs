using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opasnost : MonoBehaviour
{
    public Transform opasnost1;
    public Transform opasnost2;
    public Transform player;
    public Vector3 offset;



    void FixedUpdate()
    {
        //Random rand = new Random();
        transform.position = player.position + offset;
        

    }
}
