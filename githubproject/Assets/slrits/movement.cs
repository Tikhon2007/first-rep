using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2000f;
    public float staticspeed = 2000f;
    public float storoni = 200f;
    void Start()
    {
        Debug.Log("hello");
        //rb.useGravity = false;
        //rb.AddForce(0,0,100);
    }
    void FixedUpdate()
    {

        rb.AddForce(0, 0, staticspeed);
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(storoni, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-storoni, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed);
        }
    }
}
