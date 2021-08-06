using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class box_move : MonoBehaviour // do genrowanych kostek w skrypcie generatora (czyli nigdzie nie dodawać)
{
    static public float x, y, z;

    void Update()
    {
        z = transform.localPosition.z;
        x = transform.localPosition.x;
        y = transform.localPosition.y;
    }
}
