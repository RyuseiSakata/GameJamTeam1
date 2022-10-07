using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtimer : MonoBehaviour
{
    private Timer timercs;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        timercs = GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timercs.SetTime(0,(int)time);
    }
}
