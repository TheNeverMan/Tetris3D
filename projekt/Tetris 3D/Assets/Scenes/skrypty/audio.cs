using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
  bool if_played = false;
  AudioSource audio_source;
  float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      time = time + 1 * Time.deltaTime;
    }
    void OnCollisionEnter(Collision col)
    {
      if_played = true;
      if(time % 2 < 0.5)
      {
        audio_source.Play();
        if_played = false;
      }
    }
}
