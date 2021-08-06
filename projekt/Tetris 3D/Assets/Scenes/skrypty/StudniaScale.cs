using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudniaScale : MonoBehaviour
{
    public GameObject studnia;
    void Start()
    {
        studnia.transform.localScale = new Vector3((float)MenuScript.scale_of_studnia, (float)MenuScript.scale_of_studnia, 1);
    }

    
}
