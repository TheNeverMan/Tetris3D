using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public GameObject exi;
    public GameObject start;
    public GameObject hard;
    public GameObject ez;
    public GameObject back;
    public static int scale_of_studnia;
    private void Awake()
    {
        ez.SetActive(false);
        hard.SetActive(false);
        back.SetActive(false);
    }
    public void menuStart()
    {
         ez.SetActive(true);
         hard.SetActive(true);
         back.SetActive(true);
         exi.SetActive(false);
         start.SetActive(false);
          
        //SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        
        ez.SetActive(false);
        hard.SetActive(false);
        back.SetActive(false);
        exi.SetActive(true);
        start.SetActive(true);
        
    }
    public void Hard()
    {
        scale_of_studnia = 4;
        SceneManager.LoadScene(1);
    }
    public void Easy()
    {
        scale_of_studnia = 8;
        SceneManager.LoadScene(1);
    }


}
