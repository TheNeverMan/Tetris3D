using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauza : MonoBehaviour
{
    public bool Pause;
    //public GameObject button;
    /*private void Awake()
    {
        button.SetActive(false);
    }
    */
    private void Update()
    {
        // Debug.Log(Pause);
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!Pause)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
                Pause = true;
                //button.SetActive(true);
            }
            else if (Pause)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                Pause = false;
                //button.SetActive(false);
            }

        }
    }


}
