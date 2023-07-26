using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SceneChange(string scene) // ボタンを押された時stringで書いたシーンの所に移動
    {
        SceneManager.LoadScene(scene);
    }
}
