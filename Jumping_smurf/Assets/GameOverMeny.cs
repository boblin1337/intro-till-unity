using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMeny : MonoBehaviour
{

    
   
    public void GameOver ()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }




}
