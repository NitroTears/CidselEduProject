using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneChanger : MonoBehaviour
{
    public string newScene;
    public string finalSceneGood, finalSceneBad;
    public int requiredScore;
    public bool inUse = true;
    public bool finalScene = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (inUse && !finalScene)
        {
            SceneManager.LoadScene(newScene, LoadSceneMode.Single);
        }
        else if (inUse && finalScene)
        {
            var score = PersistantData.GetTotalScore();
            if (score > requiredScore)
            {
                SceneManager.LoadScene(finalSceneGood, LoadSceneMode.Single);
                return;
            }
            SceneManager.LoadScene(finalSceneBad, LoadSceneMode.Single);
        }
    }
}
