using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timehyouji : MonoBehaviour
{


    //public float counttime = 10;
    public line time;
    public float counttime2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //getPos();
      counttime2 = time.counttime;
       GetComponent<Text>().text = counttime2.ToString("F2");

  }

}
