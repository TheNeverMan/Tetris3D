using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// do block1 w skrypcie do generowania blocków (nie dodawać nigdzie)
public class box_control : MonoBehaviour
{
private bool canmove = true;
public static bool spawnmore = false;
Rigidbody rb ;
private bool ifdead = false;
    public GameObject otherGameObject;
  void OnCollisionEnter(Collision col)
  {
    rb.drag=1;
    canmove=false;
    if(!ifdead)
    spawnmore=true;
    ifdead=true;
  //  Debug.Log("collsion 12");
  }
  void Awake()
  {
            rb = GetComponent<Rigidbody>();
            canmove = true;
            spawnmore = false;
          ifdead = false;

  }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(canmove)
      {
        if(Input.GetKey(KeyCode.Space))
        {
          rb.drag = -1 ;
          canmove = false;
        }
float horIn = Input.GetAxis("Horizontal");
float verIn = Input.GetAxis("Vertical");
if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
{
//  Debug.Log("WS " + horIn);
  rb.velocity= new Vector3(rb.velocity.x,rb.velocity.y,verIn*10f);

}
      if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
      {
      //  Debug.Log("AD " + horIn);
        rb.velocity= new Vector3(horIn*10f,rb.velocity.y,rb.velocity.z);

      }
      /*if(Input.GetKey(KeyCode.D))
      {
        Debug.Log("D");
        rb.velocity= new Vector3(horIn*10f,rb.velocity.y,rb.velocity.z);

      // }*/
      if(Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.CapsLock))
      {
        Vector3 euler = transform.rotation.eulerAngles;
        euler.y += 4;
        euler.x += 0;
        euler.x = Mathf.Clamp(euler.x, 0f, 360f);
        transform.localRotation = Quaternion.Euler(euler);

      }
      if(Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.CapsLock))
      {
        Vector3 euler = transform.rotation.eulerAngles;
        euler.y -= 4;
        euler.x += 0;
        euler.x = Mathf.Clamp(euler.x, 0f, 360f);
        transform.localRotation = Quaternion.Euler(euler);

      }
      if(Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.CapsLock))
      {
        Vector3 euler = transform.rotation.eulerAngles;
        euler.y += 0;
        euler.x += 4;
        euler.x = Mathf.Clamp(euler.x, 0f, 360f);
        transform.localRotation = Quaternion.Euler(euler);

      }
      if(Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.CapsLock))
      {
        Vector3 euler = transform.rotation.eulerAngles;
        euler.y += 0;
        euler.x -= 4;
        euler.x = Mathf.Clamp(euler.x, 0f, 360f);
        transform.localRotation = Quaternion.Euler(euler);

      }
      }

}
}
