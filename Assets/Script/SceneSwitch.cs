using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SceneChange(string scene) // �{�^���������ꂽ��string�ŏ������V�[���̏��Ɉړ�
    {
        SceneManager.LoadScene(scene);
    }
}
