using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ustaw to gdziekolwiek
public class score : MonoBehaviour
{
    public static float scoreCount = 0;
    public static bool endGame = false;
    void Start()
    {
        scoreCount = 0;
        endGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!endGame) scoreCount = scoreCount + 1 * Time.deltaTime;
    }
}
