using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void Play()
    {
        // mettre apres le menu démarrer 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
