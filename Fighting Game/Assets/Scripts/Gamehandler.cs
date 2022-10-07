using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Gamehandler : MonoBehaviour
{
    public static Gamehandler gamescript;
    public void NextScene()
    {
        SceneManager. LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene()
    {
        SceneManager. LoadScene("Scene 2");
    }

    public void exitApplication(){

        Application.Quit();
        Debug.Log("Exit.");
    }


}
