using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam2 : MonoBehaviour
{
        
    private float z = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel") * 3f;
        z = transform.localPosition.z;
       
        Debug.Log(z);
       
           
            transform.localPosition += new Vector3(0, 0, mouseWheel);
       
        
    }
}
