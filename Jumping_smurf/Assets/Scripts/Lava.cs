using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// H�r har jag min lava class. Detta g�r s� n�r jag nuddar marken med detta script
/// s� loadar gameover menyn
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
