using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutIn : MonoBehaviour
{
    [SerializeField] private Image im;
    [SerializeField] private Sprite sp90, sp80, sp70, sp60;
    public Count c;
    public int num;
    public int ricenum;
    public int calnum;
    int k = 0;
    int f = 1;
    int m;
    private IEnumerator myCol;
    public AudioSource audioSource;
    GameObject gm;
    //[SerializeField] private float rightPos, leftPos;
    // [SerializeField] private
    // Start is called before the first frame update
    void Start()
    {
        im.enabled = false;
        num = c.num;
        audioSource.Stop();
        gm = GameObject.Find("GameMaster");
        //CutInStart(1);
        //im.sprite = sp90;
    }

    // Update is called once per frame
    void Update()
    {
      if(gm.GetComponent<GameMaster>().flag == 1){
      audioSource.Stop();
    }
    }

    private IEnumerator IllustMove() {//�܂������Ȃ��΁[orz
        /*�������Ă����ǂ������悭�Ȃ�����
        im.rectTransform.Translate(new Vector3((leftPos-rightPos)*5/15,0,0));
        yield return new WaitForSeconds(.1f);
        im.rectTransform.Translate(new Vector3((leftPos - rightPos) * 4 / 15, 0, 0));
        yield return new WaitForSeconds(.1f);
        im.rectTransform.Translate(new Vector3((leftPos - rightPos) * 3 / 15, 0, 0));
        yield return new WaitForSeconds(.1f);
        im.rectTransform.Translate(new Vector3((leftPos - rightPos) * 2 / 15, 0, 0));
        yield return new WaitForSeconds(.1f);
        im.rectTransform.position = new Vector3(leftPos, im.rectTransform.position.y, im.rectTransform.position.z);
        yield return new WaitForSeconds(.5f);
        //�߂�
        im.rectTransform.Translate(new Vector3((rightPos - leftPos)  /7, 0, 0));
        yield return new WaitForSeconds(.1f);
        im.rectTransform.Translate(new Vector3((rightPos - leftPos) * 2 / 7, 0, 0));
        yield return new WaitForSeconds(.1f);
        im.rectTransform.Translate(new Vector3((rightPos - leftPos) * 3 / 7, 0, 0));
        yield return new WaitForSeconds(.1f);

        Debug.Log(im.rectTransform.position.x);
        im.rectTransform.position = new Vector3(rightPos, im.rectTransform.position.y, im.rectTransform.position.z);
        */
        //�_�Ńp�^�[��
        /*im.enabled = true;
        yield return new WaitForSeconds(.1f);
        im.enabled = false;
        yield return new WaitForSeconds(.1f);
        im.enabled = true;
        yield return new WaitForSeconds(.1f);
        im.enabled = false;
        yield return new WaitForSeconds(.1f);*/
        im.enabled = true;
        yield return new WaitForSeconds(2.5f);
        im.enabled = false;
        f = 1;
        yield break;
    }

    public void CutInStart(int i) {//���̃��\�b�h�ŃJ�b�g�C���J�n�A1��90%,2��80%,3��70%,4��60%
        Debug.Log("CutIn" + i);
        switch (i) {
            case 1:
                im.sprite = sp90;
                break;
            case 2:
                im.sprite = sp80;
                break;
            case 3:
                im.sprite = sp70;
                break;
            case 4:
                im.sprite = sp60;
                if(gm.GetComponent<GameMaster>().flag == 0){
                audioSource.Play();
              }
                break;
            default:
                break;
        }
        StartCoroutine("IllustMove");
    }




    //1,2,3,4,5
}
