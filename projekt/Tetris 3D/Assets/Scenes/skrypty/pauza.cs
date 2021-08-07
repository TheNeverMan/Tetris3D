using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauza : MonoBehaviour
{
    public static bool Pause;
    public GameObject two;
    public GameObject ret;
    public GameObject esc;
    private void Awake()
    {
        two.SetActive(false);
        esc.SetActive(false);
        ret.SetActive(false);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Pause)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
                Pause = true;
                two.SetActive(true);
                esc.SetActive(true);
                ret.SetActive(true);
            }


        }

    }
    public void Return()
    {
        if (Pause)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
            Pause = false;

            two.SetActive(false);
            esc.SetActive(false);
            ret.SetActive(false);
        }
    }
    public void exit()
    {
        SceneManager.LoadScene(0);
    }

}
