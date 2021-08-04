using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movement : MonoBehaviour
{
  private Rigidbody rb;
  private void Awake()
  {
    rb  = GetComponent<Rigidbody>();
  }
    // Start is called before the first frame update
    public int force = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rb.AddForce(Vector3.right * force);
      rb.velocity = Vector3.right *2f;
    }
    //private void OnMouse
}
