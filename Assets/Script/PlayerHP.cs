using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[0];
    public int Life = 5;

    AudioSource sound;


    private void Start()
    {
        sound = GetComponent<AudioSource>();
         
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lifeArray[Life  -1].SetActive(false);

            Life --;

            sound.Play();
            if (Life == 0)//もしライフが０になったらゲームオーバーシーンを切り替える
            {
                //Debug.Log("ゲームオーバー");
                SceneManager.LoadScene("GameOver");
            }

            Destroy(collision.gameObject);

        }
        //if (collision.gameObject.tag == "Heart")
        //{
        //    lifeArray[Life + 1].SetActive(false);
        //    Life++;
        //}
        /*
        if (collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("GameClearScene");
        }
        */

        if (collision.gameObject.tag == "Gun")
        {
            Destroy(collision.gameObject);
        }
    }
}
