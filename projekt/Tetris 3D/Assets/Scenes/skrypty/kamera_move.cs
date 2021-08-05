using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_move : MonoBehaviour //do kamery
{
    public float cameraYPosDiff = 10f;

    void Update()
    {
        transform.position = new Vector3(0, box_move.y - cameraYPosDiff);
    }
}
