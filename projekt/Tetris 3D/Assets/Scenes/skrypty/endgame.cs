using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//do powierczhni której jak dotknie kostka to przegrywasz (czyli plane)
public class endgame : MonoBehaviour
{
    private float cooldown;

    void Start()
    {
        cooldown = 0;
    }

    void Update()
    {
        cooldown = cooldown + 1 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision col)
    {
        if (cooldown > 5)
        {
            score.endGame = true;
        }
    }
}
