using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("jumping_smurf");
    }

    
    void Update()
    {
        
    }
}
