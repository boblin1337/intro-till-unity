using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// Här har jag min gamovermeny class. Detta gör så att gameover scenen loadar.
/// </summary>


public class GameOverMeny : MonoBehaviour
{

    public TextMeshProUGUI poang;

    public void GameOver ()
    {
        SceneManager.LoadScene("GameOverMeny");
    }

    public void Update()
    {
        
    }

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        poang.text = highscore.timerscore.ToString();
    }

}
