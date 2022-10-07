using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Backtyuto : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioSource audioSource2;
    void Start()
    {
      audioSource.Stop();
      audioSource2.Stop();
      StartCoroutine(DelayCoroutine(5, () =>
      {
          // 3秒後にここの処理が実行される
          audioSource2.Play();
      }));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GoTutorialButton()
    {
      audioSource.Play();
      StartCoroutine(DelayCoroutine(0.5f, () =>
      {
          // 3秒後にここの処理が実行される
          SceneManager.LoadScene("Tutorial");
      }));
    }

    private IEnumerator DelayCoroutine(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
