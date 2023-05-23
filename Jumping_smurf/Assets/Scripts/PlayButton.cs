using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Här är min playbutton class. Detta gör så att i början när man trycker på play
/// loadar scenen med spelet så man börjar köra. 
/// </summary>

public class PlayButton : MonoBehaviour
{
   
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
