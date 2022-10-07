using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rice2 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRB;
    //public float stetchPower;
    [SerializeField] private float maxStetchPower , zeroStetchTime ,itameowariColorTime,r,b,g ,itameowariColorRandomTime;
    private float itameTime;
    [SerializeField] private SpriteRenderer mySP;
    [SerializeField] private Color color1,color2,color3,color4,color5;
    // Start is called before the first frame update
    void Start()
    {
        itameowariColorTime += Random.Range(0, itameowariColorRandomTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (itameTime < zeroStetchTime && itameTime < itameowariColorTime) {
            itameTime += Time.deltaTime;
        }
        if (itameowariColorTime / 4 > itameTime)
        {
            mySP.color = color1;
        }
        else if (itameowariColorTime * 2 / 4 > itameTime)
        {
            mySP.color = color2;
        }
        else if (itameowariColorTime * 3 / 4 > itameTime)
        {
            mySP.color = color3;
        }
        else if (itameowariColorTime > itameTime)
        {
            mySP.color = color4;
        }
        else 
        {
            mySP.color = color5;
        }

    }

    private void OnCollisionExit2D(Collision2D collision) //normalized
    {
        if (collision.gameObject.tag == "rice")
        {
            if (itameTime < zeroStetchTime) {
                myRB.AddForce((collision.transform.position - this.transform.position).normalized * maxStetchPower * (1- itameTime/zeroStetchTime), ForceMode2D.Impulse);
            }

        }
    }
}
