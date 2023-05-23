using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// H�r �r min mainmenu class. Den �r till f�r att kunna k�ra igen n�r man d�r.
/// S� den loadar spelet igen.
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