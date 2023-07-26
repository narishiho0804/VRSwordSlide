using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    
        
         //SceneManager.LoadScene("");
       


    void title()
    {
        SceneManager.LoadScene("Tile");
    }

    void Game1Start()
    {
        SceneManager.LoadScene("Debugging9");
    }
}
