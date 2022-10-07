using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AchieveMent : MonoBehaviour
{
    [SerializeField] private Sprite class1, class2, class3, class4, class5;
    [SerializeField] private Image image;
    [SerializeField] private int score;
      public AudioSource audioSource1;
      public AudioSource audioSource2;
      public AudioSource audioSource3;
      public AudioSource audioSource4;
      public AudioSource audioSource5;

    //[SerializeField] private Text text;
    // Start is called before the first frame update
    void Start()
    {
        //score = Int32.Parse(text.text);
        score = GameObject.Find("GameMaster").GetComponent<GameMaster>().time;
        if (score < 30)
        {
            //1
            audioSource5.Play();
            image.sprite = class1;
        }
        else if (score < 60)
        {
            //2
            audioSource4.Play();
            image.sprite = class2;
        }
        else if (score < 150)
        {
            //3
            audioSource3.Play();
            image.sprite = class3;
        }
        else if (score < 240)
        {
            //4
            audioSource2.Play();
            image.sprite = class4;
        }
        else
        {
            //5
            audioSource1.Play();
            image.sprite = class5;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
