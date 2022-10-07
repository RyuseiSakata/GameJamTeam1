using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class line : MonoBehaviour
{
    public float line_y;
    Vector3 pos;
    Transform myTransform;
    public float counttime = 10;
    public int k = 1;
    int boolean = 0;
    public AudioSource audioSource;
    //private GameMaster gm;
    GameObject gm;
    [SerializeField] private float upRange;
    private bool tyouri = false;
    // Start is called before the first frame update
    void Start()
    {
      gm = GameObject.Find("GameMaster");
      audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
      //getPos();
       myTransform = this.transform;
       pos = myTransform.position;

       if(counttime <= 0 && k == 1){
         Debug.Log("判定〜");
         Gameovera();
         //k = 0;
       }
       //GetComponent<Text>().text = counttime.ToString("F2");
       if(k != 3 && tyouri){
            
       counttime -= Time.deltaTime;
    }
  }

    private void Gameovera(){

      if(boolean == 0){
        k = 3;
      /*  var millsec = 123456;
        var timeScore = new System.TimeSpan (0, 0, 0, 0, millsec);
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking (timeScore);*/
        Debug.Log("がめおべら");
        gm.GetComponent<GameMaster>().GameOver();
        //GameMaster.Instance.GameOver();
      }
        else{
            transform.Translate(new Vector3(0,upRange,0));
        counttime = 10;
        k = 1;
        boolean = 0;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        if(gm.GetComponent<GameMaster>().flag == 0){
        audioSource.Play();
      }
      }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "rice")
        {
          Debug.Log("aa");
          gameObject.GetComponent<Renderer>().material.color = Color.blue;
          //line_y = line_y + 3;
          //audioSource.Play();
            boolean = 1;
          /*pos.y += 2.00f;
          myTransform.position = pos;*/
        }
    }

    /*public void getPos(){

       tmp = GameObject.Find("line").transform.position;
       line_y = tmp.y;
    }*/

    public void GameStart() {
        tyouri = true;
    }
}
