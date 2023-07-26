using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text countText;
    // カウントアップ変数
    int count = 3;


    
    IEnumerator Start()
    {
        

        //Debug.Log("カウントダウン開始");
        yield return Count();

        //yield return "GO";
        //Debug.Log("カウントダウン終了");
    }

    IEnumerator Count()
    {
        
        while (count >= 1)
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1f);
            countText.text = count.ToString();// 表示用の「countText」にcount変数の値をセット
            count--;
            if(count == 1)
            {
                
                countText.text = "GO!";
            }
        }
    }
}
