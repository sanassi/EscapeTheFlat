using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 1f;
    public Hero hero;
    public GameObject completeLevelUI;
    public GameObject healthBarUI;
    public GameObject staminaBarUI;
    public GameObject timerUI;
    public GameObject levelLostUI;


    public void CompleteLevel()
    {
        healthBarUI.SetActive(false);
        staminaBarUI.SetActive(false);
        timerUI.SetActive(false);
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            healthBarUI.SetActive(false);
            staminaBarUI.SetActive(false);
            timerUI.SetActive(false);
            completeLevelUI.SetActive(false);
            levelLostUI.SetActive(true);
            gameHasEnded = true;
            InvokeRestart();
        }
        
    }

    void InvokeRestart()
    {
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
