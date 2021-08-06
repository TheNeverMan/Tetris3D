using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
  public  AudioClip audio_1;
  public  AudioClip audio_2;
  public  AudioClip audio_3;
  public  AudioClip audio_4;
  public  AudioClip audio_5;
  public  AudioClip audio_6;
  public  AudioClip audio_7;
  public  AudioClip audio_8;
  public  AudioClip audio_9;
  public  AudioClip audio_10;
  public  AudioClip audio_11;
  public  AudioClip audio_12;
  public  AudioClip audio_13;
  public  AudioClip audio_14;

  AudioSource audio_source;
    // Start is called before the first frame update
    void Start()
    {
      //audio_1.Create("1.mp2",);
        audio_source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
      //if_played = true;
      //if(time % 2 < 0.8)
      int blocksNumber = Random.Range(1,14);
      switch (blocksNumber)
      {
        case 1:
        audio_source.clip=audio_1;
        break;
        case 2:
        audio_source.clip=audio_2;
        break;
        case 3:
        audio_source.clip=audio_3;
        break;
        case 4:
        audio_source.clip=audio_4;
        break;
        case 5:
        audio_source.clip=audio_5;
        break;
        case 6:
        audio_source.clip=audio_6;
        break;
        case 7:
        audio_source.clip=audio_7;
        break;
        case 8:
        audio_source.clip=audio_8;
        break;
        case 9:
        audio_source.clip=audio_9;
        break;
        case 10:
        audio_source.clip=audio_10;
        break;
        case 11:
        audio_source.clip=audio_11;
        break;
        case 12:
        audio_source.clip=audio_12;
        break;
        case 13:
        audio_source.clip=audio_13;
        break;

        default:
        break;
      }
        audio_source.Play();

    }
}
