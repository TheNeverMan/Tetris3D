using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    private float fovZ = 0f;
    public float fovMax = -61f;

    void Update()
    {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel") * 30f;
        fovZ = transform.localPosition.z + mouseWheel;

        if (fovZ < -19f && fovZ > fovMax)
            transform.localPosition += new Vector3(0, 0, mouseWheel);
    }
}
