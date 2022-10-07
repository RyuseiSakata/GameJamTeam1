using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fripan : MonoBehaviour
{
    // Start is called before the first frame update
    public float bairitup = 0;
    private float bairitu;
    Rigidbody2D rigid2D;
    [SerializeField] float difx;
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

      }
      else if(difx <-8){
        bairitu = 0.06f;
        bairitup = 1.1f;

      }
     else if(difx <-7){
        bairitu = 0.065f;
        bairitup = 1.2f;

      }
       else if(difx <-6){
        bairitu = 0.07f;
        bairitup = 1.3f;

      }
      else if(difx <-5){
        bairitu = 0.075f;
        bairitup = 1.4f;

      }
       else if(difx <-4){
        bairitu = 0.08f;
        bairitup = 1.5f;

      }
       else if(difx <-3){
        bairitu = 0.085f;
        bairitup = 1.6f;

      }
       else if(difx <-2){
        bairitu = 0.09f;
        bairitup = 1.7f;

      }
       else if(difx <-1){
        bairitu = 0.095f;
        bairitup = 1.8f;

      }
      else if(difx < 0){
          bairitup = 2;
      }
       if(difx >= 0){
        bairitu = 2;
      }
       if(difx > 1){
        bairitu = 1;
        bairitup = -20.0f;
      }
       if(difx > 2){
        bairitu = 1.5f;
        bairitup = -30.0f;
      }
     if(difx > 3){
        bairitu = 2;
        bairitup = -4.0f;
      }
       if(difx > 4){
        bairitu = 3;
        bairitup = -5.0f;
      }
      if(difx > 5){
        bairitu = 4;
        bairitup = -6.0f;
      }
       if(difx > 6){
        bairitu = 6;
        bairitup = -7.0f;
      }
       if(difx > 7){
        bairitu = 7;
        bairitup = -8.0f;
      }
       if(difx > 8){
        bairitu = 8;
        bairitup = -9.0f;
      }
       if(difx > 9){
        bairitu = 9;
        bairitup = -10.0f;
      }
     if(difx > 10){
        bairitu = 10;
        bairitup = -11.0f;
      }

      bairitup = bairitup*4;

    }
    // Update is called once per frame
    void Update()
    {
      getPos();
      bairitucal();
      if(Input.GetKeyDown(KeyCode.Space) ){
          this.rigid2D.AddForce(transform.up * bairitup, ForceMode2D.Impulse);
          //this.rigid2D.AddForce(transform.right * bairitu, ForceMode2D.Impulse);



      }
    }
}
