using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GoRyuku : MonoBehaviour
{
  public AudioSource audioSource;

  void Start(){
    audioSource.Stop();
  }

   public void GoRyukkuButton()
    {

      audioSource.Play();
      StartCoroutine(DelayCoroutine(0.5f, () =>
      {
          // 3秒後にここの処理が実行される
          SceneManager.LoadScene("Ryukku_Fraipan");
      }));
        //SceneManager.LoadScene("Ryukku_Fraipan");
    }
    
    private IEnumerator DelayCoroutine(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
