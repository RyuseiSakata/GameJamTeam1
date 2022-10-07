using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int time= 0;//�u�ߎn�߂Ă����̎���
    public bool tyouri = false;//��������true�A���ڏ�����������
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public int flag = 0;
    //[SerializeField]private Text text;
    [SerializeField] private Image countdownIm;
    [SerializeField] private Sprite im3,im2,im1,im0;
    public static GameMaster Instance;
    [SerializeField] private GameObject bacon, egg, chicken, onion, mentai, salmon, shrimp;
    [SerializeField] private GameObject FryingPan;
    [SerializeField] private GameObject Audio;


    private int guzaiSelect;
    [SerializeField] private int guzaiTime;//
    [SerializeField] private int guzaiThroughtTime;//
     private int guzaiTimeCount = 0;
     private int guzaiThroughtTimeCount = 0;
    [SerializeField] private Vector3 throughtPos;
    [SerializeField] private line line;
    [SerializeField] private Timer timerCs;

    GameObject canvastimers = null;
    [SerializeField] private TeleVision teleVisionCs;




    //[SerializeField]�Ń^�C�}�[�̃X�N���v�g�ǉ�
    //TV�̃X�N���v�g�ǉ�
    //�����������ނ̔z���ǉ�

    /*���ފ֌W�̏���

    private int Guzai;//�����������ނ̒��I
    */



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CountDown");
        canvastimers = GameObject.Find("Canvas");
        audioSource3.Stop();
        //audioSource4.Stop();
        audioSource.Stop();
        audioSource2.Stop();
        //audioSource = GameObject.Find("MainCamera").GetComponent<AudioSource>();
      //  gm = this;
      //audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator CountDown()
    {
        countdownIm.sprite = im3;
        audioSource4.Play();
        yield return new WaitForSeconds(1);
        countdownIm.sprite = im2;
        audioSource4.Play();
        yield return new WaitForSeconds(1);
        countdownIm.sprite = im1;
        audioSource4.Play();
        yield return new WaitForSeconds(1);
        countdownIm.sprite = im0;
        audioSource3.Play();
        GameStart();
        yield return new WaitForSeconds(1);
        audioSource.Play();
        audioSource2.Play();
        countdownIm.enabled = false;
        yield break;
    }

    private IEnumerator TimeCount() {
        while (true) {
            yield return new WaitForSeconds(1);
            time++;
            //時間セット
            int m, s;
            m = time / 60;
            s = time - m * 60;
            timerCs.SetTime(m,s);
            Debug.Log(time);
            //具材の処理
            if (guzaiTime > guzaiTimeCount)
            {
                guzaiTimeCount++;
            }
            else {
                if (guzaiThroughtTimeCount == 0)
                {
                    //抽選
                    int i = Random.Range(1,22);
                    if (i <= 4)
                    {
                        guzaiSelect = 1;
                    }
                    else if (i <= 8)
                    {
                        guzaiSelect = 2;
                    }
                    else if (i <= 12)
                    {
                        guzaiSelect = 3;
                    }
                    else if (i <= 15)
                    {
                        guzaiSelect = 4;
                    }
                    else if (i <= 17)
                    {
                        guzaiSelect = 5;
                    }
                    else if (i <= 21)
                    {
                        guzaiSelect = 6;
                    }
                    else {
                        guzaiSelect = 7;
                    }
                    guzaiThroughtTimeCount++;
                    //表示
                    teleVisionCs.SetImage(guzaiSelect);

                }
                else if (guzaiThroughtTimeCount < guzaiThroughtTime)
                {
                    guzaiThroughtTimeCount++;
                }
                else {
                    Debug.Log("guzaiTouka");
                    //投下bacon, egg, chicken, onion, mentai, salmon, shrimp;
                    teleVisionCs.SetImage(0);
                    switch (guzaiSelect) {
                        case 1:
                            Instantiate(bacon, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            Instantiate(bacon, FryingPan.transform.position + throughtPos + new Vector3(-0.2f, -0.1f, 0), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(egg, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            Instantiate(egg, FryingPan.transform.position + throughtPos + new Vector3(-0.2f, -0.1f, 0), Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(onion, FryingPan.transform.position + throughtPos + new Vector3(-0.2f,-0.1f,0), Quaternion.identity);
                            Instantiate(onion, FryingPan.transform.position + throughtPos + new Vector3(0.2f, 0.1f, 0), Quaternion.identity);
                            Instantiate(onion, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            break;
                        case 4:
                            Instantiate(shrimp, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            break;
                        case 5:
                            Instantiate(chicken, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            break;
                        case 6:
                            Instantiate(salmon, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            break;
                        default:
                            Instantiate(mentai, FryingPan.transform.position + throughtPos + new Vector3(-0.2f, -0.1f, 0), Quaternion.identity);
                            Instantiate(mentai, FryingPan.transform.position + throughtPos + new Vector3(0.2f, -0.1f, 0), Quaternion.identity);
                            Instantiate(mentai, FryingPan.transform.position + throughtPos + new Vector3(-0.2f, 0.1f, 0), Quaternion.identity);
                            Instantiate(mentai, FryingPan.transform.position + throughtPos + new Vector3(0.2f, 0.1f, 0), Quaternion.identity);
                            Instantiate(mentai, FryingPan.transform.position + throughtPos, Quaternion.identity);
                            break;

                    }
                    guzaiThroughtTimeCount = 0;
                    guzaiTimeCount = 0;
                }
            }
        }
    }


    public void GameStart() {//!!���������A�N�Z�X���܂���!!�Q�[���J�n���A�܂��J�E���g�_�E���I�����ɃA�N�Z�X
        tyouri = true;
        line.GameStart();
        //�^�C�}�[�ւ̃A�N�Z�X�������ǉ�
        StartCoroutine("TimeCount");
    }


    public void GameOver() { //�Q�[���I�[�o�[�������ɃA�N�Z�X���Ă��������A�Ă��������Ƃ��ƕĂ��������ƐU���Ȃ��������ł�
        tyouri = false;
        Debug.Log("しゅーりょー");
        if(flag == 0){
        var millsec = 1000 * time;
          var timeScore = new System.TimeSpan (0, 0, 0, 0, millsec);
          naichilab.RankingLoader.Instance.SendScoreAndShowRanking (timeScore);
          audioSource.Stop();
          audioSource2.Stop();
        /*
          naichilab.RankingLoader.Instance.SendScoreAndShowRanking (time);
          canvastimers.SetActive(false);
        */
        StopCoroutine("TimeCount");
        flag = 1;
      }
    }
}
