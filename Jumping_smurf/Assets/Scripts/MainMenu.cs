using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// Här är min mainmenu class. Den är till för att kunna köra igen när man dör.
/// Så den loadar spelet igen.
/// </summary>

public class MainMenu : MonoBehaviour
{

    

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Start()
    {
        
    }


}