using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Här har jag min lava class. Detta gör så när jag nuddar marken med detta script
/// så loadar gameover menyn
/// </summary>

public class Lava : MonoBehaviour
{

    Timer tid;
    public bool klar;
    
    void OnTriggerEnter(Collider other)
    {
        klar = true;
        end();
        
    }

    
    void Update()
    {
        
    }

    public void end()
    {
        
        SceneManager.LoadScene("GameOverMeny");
    }

    public void Start()
    {
        
    }
}
