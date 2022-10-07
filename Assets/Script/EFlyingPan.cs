using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFlyingPan : MonoBehaviour
{
    [SerializeField] private float maxPower;
    [SerializeField] private float chargePowerSpeed;
    private float chargePower;
    [SerializeField] private Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && maxPower > chargePower) {
            chargePower += chargePowerSpeed * Time.deltaTime;
            if (maxPower < chargePower) { chargePower = maxPower; }
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            myRB.AddForce(new Vector2(0,chargePower),ForceMode2D.Impulse);
            chargePower = 0;
        }
    }
}
