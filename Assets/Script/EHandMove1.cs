using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHandMove1 : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float pushPower;
    [SerializeField] private float maxX;
    [SerializeField] private float minX;
    [SerializeField] private Rigidbody2D myRB;

    [SerializeField] private bool suberu;
    // Start is called before the first frame update
    void Start()
    {

    }        


    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D) && myRB.velocity.x < maxSpeed)
        {
            myRB.AddForce(new Vector2(pushPower, 0));
        }
        if (Input.GetKey(KeyCode.A) && myRB.velocity.x > -maxSpeed)
        {
            myRB.AddForce(new Vector2(-pushPower, 0));
        }

        if (this.transform.position.x > maxX && myRB.velocity.x > 0)
        { //âEçsÇ´âﬂÇ¨ó\ñh
            myRB.velocity = new Vector2(0,0);
        }
        if (this.transform.position.x < minX && myRB.velocity.x < 0)
        { //âEçsÇ´âﬂÇ¨ó\ñh
            myRB.velocity = new Vector2(0, 0);
        }

        if (!suberu && !(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))) {
            myRB.velocity = Vector2.zero;
        }

    }
}
