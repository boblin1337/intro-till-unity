using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// H�r �r min playbutton class. Detta g�r s� att i b�rjan n�r man trycker p� play
/// loadar scenen med spelet s� man b�rjar k�ra. 
/// </summary>

public class PlayButton : MonoBehaviour
{
   
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
