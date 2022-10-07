using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditOffButton : MonoBehaviour
{
    [SerializeField] private Canvas creditCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
        creditCanvas.enabled = false;
    }
}
