using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//do pustego obiektu na 0,0,0
public class centrym : MonoBehaviour
{
    [SerializeField] private float camSpeed = 300f;

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
        euler.x = Mathf.Clamp(euler.x, 15f, 70f);


        transform.localRotation = Quaternion.Euler(euler);


    }
}
