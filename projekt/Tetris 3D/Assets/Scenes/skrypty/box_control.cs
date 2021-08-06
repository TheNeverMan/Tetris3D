using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_control : MonoBehaviour
{
    KeyCode rotationYKey = KeyCode.E;
    KeyCode rotationXKey = KeyCode.Q;
    KeyCode rotationRevKey = KeyCode.LeftShift;
    KeyCode downDashKey = KeyCode.Space;

    float rotationXSensivity = 0.9f;
    float rotationYSensivity = 0.9f;

    public float wsadSensivity = 10f;

    private bool canMove = true;
    public static bool spawnMore = false;
    Rigidbody rb;
    private bool ifDead = false;
    public GameObject otherGameObject;
    Vector3 euler;

    void OnCollisionEnter(Collision col)
    {
        if (!ifDead)
            spawnMore = true;

        canMove = false;
        ifDead = true;
        rb.drag = 0;
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        canMove = true;
        spawnMore = false;
        ifDead = false;
    }

    void Update()
    {
        if (canMove)
        {
            if (Input.GetKeyDown(downDashKey))
            {
                rb.drag = -1;
                rb.mass = 1;

                rb.velocity = new Vector3(0, rb.velocity.y * 0.001f, 0);

                canMove = false;
            }
            if (canMove == true)
            {
                float horIn = Input.GetAxis("Horizontal");
                float verIn = Input.GetAxis("Vertical");

                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, verIn * wsadSensivity);
                }
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                {
                    rb.velocity = new Vector3(horIn * wsadSensivity, rb.velocity.y, rb.velocity.z);
                }
                if (Input.GetKey(rotationXKey))
                {
                    euler = transform.rotation.eulerAngles;

                    if (Input.GetKey(rotationRevKey))
                    {
                        euler.x -= rotationXSensivity;
                    }
                    else
                    {
                        euler.x += rotationXSensivity;
                    }
                    Debug.Log(euler.x);

                    transform.localRotation = Quaternion.Euler(euler);
                }
                if (Input.GetKey(rotationYKey))
                {
                    euler = transform.rotation.eulerAngles;

                    if (Input.GetKey(rotationRevKey))
                    {
                        euler.y -= rotationYSensivity;
                    }
                    else
                    {
                        euler.y += rotationYSensivity;
                    }
                    transform.localRotation = Quaternion.Euler(euler);
                }
            }
        }
    }
}
