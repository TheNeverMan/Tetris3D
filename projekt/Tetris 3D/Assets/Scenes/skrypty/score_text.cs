using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_text : MonoBehaviour // do UI
{
    public Text scoreField;

    void Update()
    {
        int scoreCountInt = (int)score.scoreCount;

        if (score.endGame)
        {
          scoreField.fontSize = 18;
            scoreField.text = "YOU HAVE LOST (PRESS R TO RESTART) SCORE: " + scoreCountInt;
        }
        else
        {
          scoreField.fontSize = 24;
            scoreField.text = "SCORE: " + scoreCountInt;
        }
    }
}
