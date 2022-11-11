using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        //Reset score, load game scene again
        DangerousObjectBehavior.objectsAvoided = 0;
        SceneManager.LoadScene(sceneName);
    }
}
