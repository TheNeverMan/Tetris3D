using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//do kamery
public class kamera_move : MonoBehaviour
{
  public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        }

    // Update is called once per frame
    void Update()
    {
      transform.position = new Vector3(0,box_move.y-4,0);

      //  transform.position += new Vector3(0, speed, 0);
    }
}
