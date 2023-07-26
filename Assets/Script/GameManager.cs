using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text countText;

    public AudioSource sound;
    //public AudioClip countSE;
    private void Start()
    {
        countText.text = "";
        StartCoroutine(CountDown());
        sound = GetComponent<AudioSource>();
    }
    
    IEnumerator CountDown()
    {
        //yield return new WaitForSeconds(1);
        Debug.Log(3);
        
        countText.text = "3";

        sound.Play();
        yield return new WaitForSeconds(0.5f);

        Debug.Log(2);
        countText.text = "2";
        yield return new WaitForSeconds(1);
        Debug.Log(1);
        countText.text = "1";
        yield return new WaitForSeconds(1);
        Debug.Log("GO!");
        countText.text = "スタート!";
        yield return new WaitForSeconds(1);
        countText.enabled = false;
        //Debug.Log("Mainのシーンに切り替える");
        //SceneManager.LoadScene("Main");
    }
}
