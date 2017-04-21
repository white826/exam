using UnityEngine;
using System.Collections;

public class pickup: MonoBehaviour
{
    void OnCollisionEnter(Collision aaa) 
    {    
        if (aaa.gameObject.tag == "rotate") 
        {    
            Destroy(aaa.gameObject); 
        }
    }
}