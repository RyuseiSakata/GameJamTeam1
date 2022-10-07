using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GoTutorial : MonoBehaviour
{
  public AudioSource audioSource;
    // Start is called before the first frame update
    void Start(){
      audioSource.Stop();
    }

    public void GoTutorialButton()
    {
        audioSource.Play();
        StartCoroutine(DelayCoroutine(0.5f, () =>
        {
            // 3秒後にここの処理が実行される
            SceneManager.LoadScene("Tutorial");
        }));
        //SceneManager.LoadScene("Tutorial");

    }

    private IEnumerator DelayCoroutine(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
