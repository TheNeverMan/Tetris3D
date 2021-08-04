using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ustaw to gdziekolwiek
public class score : MonoBehaviour
{
  public static float score_count = 0;
  public static bool endgame = false;
    // Start is called before the first frame update
    void Start()
    {
        score_count = 0;
        endgame = false;
    }

    // Update is called once per frame
    void Update()
    {
      //Debug.Log(endgame);
      if(!endgame)
        score_count = score_count + 1 * Time.deltaTime;
        //Debug.Log((int)score_count);
    }
}
