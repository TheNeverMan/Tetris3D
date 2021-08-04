using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//do powierczhni której jak dotknie kostka to przegrywasz (czyli plane)
public class endgame : MonoBehaviour
{
  private float cooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
      cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
      cooldown = cooldown + 1 * Time.deltaTime;
    }
    void OnCollisionEnter(Collision col)
    {
      if(cooldown>5)
      {
        // Debug.Log("Endgame");
        score.endgame=true;
      }
    }
}
