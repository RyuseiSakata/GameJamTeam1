using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text text;
    private int minute = 0;
    private int seconds = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (minute >= 10 & seconds >= 10)
        {
            text.text = minute + ":" + seconds;
        }
        else if(minute >= 10 & seconds < 10)
        {
            text.text = minute + ":" + "0" + seconds;
        }
        else if(minute < 10 & seconds >= 10)
        {
            text.text = "0" + minute + ":" + seconds;
        }
        else
        {
            text.text = "0" + minute + ":" + "0" + seconds;
        }
        
    }
    public void SetTime(int m,int s)
    {
        minute = m;
        seconds = s;
    }
}
