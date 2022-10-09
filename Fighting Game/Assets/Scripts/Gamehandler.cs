using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Gamehandler : MonoBehaviour
{
    public static Gamehandler gamescript;

    public static string P1Name, P2Name;
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

    public void P1NameInput(string name)
    {
        P1Name = name;
    }

    public void P2NameInput(string name)
    {
        P2Name = name;
    }
}
