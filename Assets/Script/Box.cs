using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    public int ricenum = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(ricenum <= 2){
        Debug.Log("aaaa");
      }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "box")
        {
          Debug.Log("aaaa");
            Destroy(other.gameObject);
            ricenum++;

        }
        if(other.gameObject.tag == "line")
        {

        }
    }
}
