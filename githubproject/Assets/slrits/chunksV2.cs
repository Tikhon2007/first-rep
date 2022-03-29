using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunksV2 : MonoBehaviour
{
    public Transform chank1;
    public Transform chank2;
    public Transform chank3;
    public float aabbccd = 25;
    public Vector3 vpered;

    void Update()
    {
        if(transform.position.z -aabbccd > chank1.position.z){
            chank1.position = chank1.position + vpered;
        }
        if(transform.position.z -aabbccd > chank2.position.z){
            chank2.position = chank2.position + vpered;
        }
        if(transform.position.z -aabbccd > chank3.position.z){
            chank3.position = chank3.position + vpered;
        }
    }
}
