using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text countText;
    // �J�E���g�A�b�v�ϐ�
    int count = 3;


    
    IEnumerator Start()
    {
        

        //Debug.Log("�J�E���g�_�E���J�n");
        yield return Count();

        //yield return "GO";
        //Debug.Log("�J�E���g�_�E���I��");
    }

    IEnumerator Count()
    {
        
        while (count >= 1)
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1f);
            countText.text = count.ToString();// �\���p�́ucountText�v��count�ϐ��̒l���Z�b�g
            count--;
            if(count == 1)
            {
                
                countText.text = "GO!";
            }
        }
    }
}
