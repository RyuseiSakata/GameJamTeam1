using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rice : MonoBehaviour
{
    public int RiceHP;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "box")
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "line")
        {

        }
    }
}
