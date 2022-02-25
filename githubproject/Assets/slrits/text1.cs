using UnityEngine;
using UnityEngine.UI;

public class text1 : MonoBehaviour
{

    public Transform player;
    public Text scoretext;
   
    void FixedUpdate()
    {
        //Debug.Log (player.position.z);
        scoretext.text = player.position.z.ToString("0") + "m";


    }
}
