using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dusman;
   // Vector3 konum = new Vector3(4, 3, 6);
    void  Start ()
    {
        Vector3 konum = new Vector3(Random.Range(3, 12), transform.position.y, Random.Range(5, 15));
       Instantiate(dusman,konum,Quaternion.identity);
       
       
    }
    
    void Update()
    {
        
    }
}
