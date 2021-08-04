using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{

    private float z = 0f;
    void Start()
    {

    }


    void Update()
    {
        if(transform.localPosition.z <= -75)
        {
          transform.localPosition = new Vector3(0, 0, -74);

      }
        if(transform.localPosition.z >= -18)
        {
          transform.localPosition = new Vector3(0, 0, -19);

      }
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel") * 30f;
        z = transform.localPosition.z + mouseWheel;

      //  Debug.Log(z);

            if(z <= -18 || z >= -75)
            {
            transform.localPosition += new Vector3(0, 0, mouseWheel);
}

    }
}
