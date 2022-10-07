using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleVision : MonoBehaviour
{
    [SerializeField] private Image im;
    [SerializeField] private Sprite Image1, Image2, Image3, Image4, Image5, Image6, Image7;
    // Start is called before the first frame update
    void Start()//
    {
        //ï\é¶Çè¡Ç∑
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetImage(int i)
    {
        switch (i)
        {
            case 0:
                this.gameObject.GetComponent<Image>().sprite = null;
                //ï\é¶Çè¡Ç∑
                this.gameObject.SetActive(false);
                break;
            case 1:
                this.gameObject.GetComponent<Image>().sprite = Image1;
                //ï\é¶Ç∑ÇÈ
                this.gameObject.SetActive(true);
                break;
            case 2:
                this.gameObject.GetComponent<Image>().sprite = Image2;
                this.gameObject.SetActive(true);
                break;
            case 3:
                this.gameObject.GetComponent<Image>().sprite = Image3;
                this.gameObject.SetActive(true);
                break;
            case 4:
                this.gameObject.GetComponent<Image>().sprite = Image4;
                this.gameObject.SetActive(true);
                break;
            case 5:
                this.gameObject.GetComponent<Image>().sprite = Image5;
                this.gameObject.SetActive(true);
                break;
            case 6:
                this.gameObject.GetComponent<Image>().sprite = Image6;
                this.gameObject.SetActive(true);
                break;
            case 7:
                this.gameObject.GetComponent<Image>().sprite = Image7;
                this.gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }

}
