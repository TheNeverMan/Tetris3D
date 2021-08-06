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
            scoreField.text = "YOU HAVE LOST SCORE: " + scoreCountInt;
        }
        else
        {
            scoreField.text = "SCORE: " + scoreCountInt;
        }
    }
}
