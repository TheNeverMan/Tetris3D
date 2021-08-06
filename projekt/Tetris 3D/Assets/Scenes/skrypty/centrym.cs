using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrym : MonoBehaviour //do pustego obiektu na 0,0,0
{
    [SerializeField] public static float cameraSensivity = 300f;
    Vector3 euler;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        euler = transform.rotation.eulerAngles;

        euler.y += Input.GetAxis("Mouse X") * cameraSensivity * Time.deltaTime;
        euler.x += Input.GetAxis("Mouse Y") * cameraSensivity * Time.deltaTime;
        euler.x = Mathf.Clamp(euler.x, 15f, 70f);

        transform.localRotation = Quaternion.Euler(euler);
    }
}
