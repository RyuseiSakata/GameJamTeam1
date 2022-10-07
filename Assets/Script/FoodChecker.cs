using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodChecker : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private float maxV, minV,defoV, decreaseVps;
    private float v;
    // Start is called before the first frame update
    void Start()
    {
        v = maxV;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(decreaseVps * Time.deltaTime);
        if (v > minV)
        {
            Debug.Log("����");
            v -= decreaseVps * Time.deltaTime;
            if (v < minV) 
            {
                //�Œ�ۏ�
                v = minV; 
            }
        }
        Debug.Log(v);
        audioSource.volume = v;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("�G�ꂽ");
        if (collision.gameObject.tag == "rice" || collision.gameObject.tag == "food")
        {
            if (v < (defoV + minV) / 2)
            {
                v = maxV;
                Debug.Log("����" + v);
            }
            else if(v < defoV){

                v = defoV;
            }

           
        }
    }
}
