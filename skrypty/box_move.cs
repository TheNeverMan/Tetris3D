using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//do genrowanych kostek w skrypcie generatora (czyli nigdzie nie dodawać)
public class box_move : MonoBehaviour
{
  static public float x,y,z;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      if(true)
      {
      z = transform.localPosition.z;
      x = transform.localPosition.x;
      y = transform.localPosition.y;
}
      //Debug.Log(z);



    }
}
