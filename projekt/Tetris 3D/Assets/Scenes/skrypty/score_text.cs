using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//do UI
public class score_text : MonoBehaviour
{
      public Text score_field;
      private GameObject new_object;
    // Start is called before the first frame update
    void Awake()
    {
      new_object = new GameObject();
    //  score_field = new_object.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      int score_int = (int)score.score_count;
      if(score.endgame)
      {
        score_field.text = "YOU HAVE LOST SCORE: " + score_int;

    }
    else
    {
      score_field.text = "SCORE: " + score_int;

    }
  }
}
