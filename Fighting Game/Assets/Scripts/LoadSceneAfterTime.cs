using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 15.5f;
    [SerializeField]
    private string sceneNameToLoad;

    private float TimeElapsed;
    private void Update()
    {
        TimeElapsed += Time.deltaTime;

        if (TimeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
 