using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    // Start is called before the first frame update
    //GameObject objA;
    public int num;
    public int ricecount;
    private int k = 1;
    //[SerializeField] GameObject Imagecut;
    //private GameMaster gm;
    GameObject gm;
    Canvas ctin;
    private int cutInNum = 10;
    [SerializeField] private CutIn cutInCs;
    void Start()
    {
       num = this.transform.childCount;
       gm = GameObject.Find("GameMaster");
       //ctin = Canvas.Find("Image");
       //ctin.GetComponent<CutIn>().CutInStart(1);
    }

    // Update is called once per frame
    void Update()
    {
       ricecount = this.transform.childCount;

        if (ricecount <= num * 3 / 5&&cutInNum > 6) { //60%以下なら
            cutInNum = 6;
            cutInCs.CutInStart(4);
        } 
        else if (ricecount <= num * 7 / 10&&cutInNum > 7) 
        { //70%
            cutInNum = 7;
            cutInCs.CutInStart(3);
        }
        else if (ricecount <= num * 8 / 10 && cutInNum > 8)//80%
        {
            cutInNum = 8;
            cutInCs.CutInStart(2);
        }
        else if (ricecount <= num * 9 / 10&&cutInNum > 9)//90%
        {
            cutInNum = 9;
            cutInCs.CutInStart(1);
        }



        if (ricecount <= num/2 && k == 1){

        //GameMaster.gm.GameOver();
        Debug.Log("がめおべら");
        gm.GetComponent<GameMaster>().GameOver();
        k = 0;
      }
      else if(ricecount >= num*(9/10)){
      //  Imagecut.GetComponent<CutIn>().CutInStart(1);
        //ctin.GetComponent<CutIn>().CutInStart(1);
      }

      /*else if(ricecount >= num/2){
        k = 1;
      }*/
    }
}
