using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    [SerializeField] private float camSpeed = 350f;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * camSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * camSpeed * Time.deltaTime;
     

        Vector3 euler = transform.rotation.eulerAngles;
        euler.y += mouseX;
        euler.x += mouseY;
        euler.x = Mathf.Clamp(euler.x, 0f, 88f);
        
       
        transform.localRotation = Quaternion.Euler(euler);
       
        
    }
}
