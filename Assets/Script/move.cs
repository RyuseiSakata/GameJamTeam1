using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{

  //public double walkForce ;
  //public double maxWalkSpeed;

    public float walkForce = 100.0f;
    public float maxWalkSpeed = 30.0f;

    Rigidbody2D rigid2D;

    [SerializeField] float difx;

    public GameObject cocoa;
    private int m =3;
    public float bairitu = 0;
    public float bairitup = 0;

     //this.rigid2D = GetComponent<Rigidbody2D>();
    // Start is called before the first frame update
    void Start()
    {
      this.rigid2D = GetComponent<Rigidbody2D>();
    }

    public void getPos(){

      Vector3 tmp = GameObject.Find("Player").transform.position;
      float x = tmp.x;

      difx = x -0;
    }

    private void bairitucal(){
      bairitu = 0;
      bairitup = 0;
      if(difx < -9){
        bairitu = 0.05f;
        bairitup = 1;
        m =5;
      }
      else if(difx <-8){
        bairitu = 0.06f;
        bairitup = 1.1f;
        m =5;
      }
     else if(difx <-7){
        bairitu = 0.065f;
        bairitup = 1.2f;
        m =5;
      }
       else if(difx <-6){
        bairitu = 0.07f;
        bairitup = 1.3f;
        m =5;
      }
      else if(difx <-5){
        bairitu = 0.075f;
        bairitup = 1.4f;
        m =5;
      }
       else if(difx <-4){
        bairitu = 0.08f;
        bairitup = 1.5f;
        m =5;
      }
       else if(difx <-3){
        bairitu = 0.085f;
        bairitup = 1.6f;
        m =5;
      }
       else if(difx <-2){
        bairitu = 0.09f;
        bairitup = 1.7f;
        m =5;
      }
       else if(difx <-1){
        bairitu = 0.095f;
        bairitup = 1.8f;
        m =5;
      }
       if(difx >= 0){
        bairitu = 1;
      }
       if(difx > 1){
        bairitu = 1;
        bairitup = 0;
      }
       if(difx > 2){
        bairitu = 1.5f;
        bairitup = 0;
      }
     if(difx > 3){
        bairitu = 2;
        bairitup = 0;
      }
       if(difx > 4){
        bairitu = 3;
        bairitup = 0;
      }
      if(difx > 5){
        bairitu = 4;
        bairitup = 0;
      }
       if(difx > 6){
        bairitu = 6;
        bairitup = 0;
      }
       if(difx > 7){
        bairitu = 7;
        bairitup = 0;
      }
       if(difx > 8){
        bairitu = 8;
        bairitup = 0;
      }
       if(difx > 9){
        bairitu = 9;
        bairitup = 0;
      }
     if(difx > 10){
        bairitu = 10;
        bairitup = 0;
      }

      bairitup = bairitup*100;
      bairitu = bairitu*-50;
    }

    // Update is called once per frame
    void Update()
    {
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        float speedy = Mathf.Abs(this.rigid2D.velocity.y);
        bairitucal();
        getPos();

            if (Input.GetKey(KeyCode.LeftArrow) && speedx < this.maxWalkSpeed)
            {
                this.rigid2D.AddForce(transform.right * -1 * this.walkForce * Time.deltaTime);
              //  m = 1;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && speedx < this.maxWalkSpeed)
            {
                this.rigid2D.AddForce(transform.right * this.walkForce * Time.deltaTime);
                //m = 2;
            }
            else if(Input.GetKeyDown(KeyCode.Space) && speedx < this.maxWalkSpeed){
              //  this.rigid2D.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
                this.rigid2D.AddForce(transform.right * bairitu, ForceMode2D.Impulse);

              //  this.rigid2D.AddForce(transform.right * this.walkForce *bairitu()* Time.deltaTime);

            }
            else{
                    rigid2D.velocity = Vector3.zero;
                    if(m == 3){
                  //    this.rigid2D.AddForce(transform.up * -10.0f, ForceMode2D.Impulse);
                      m=4;
                    }                    //rigid2D.angularVelocity = Vector3.zer
            }




    }
}
