using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MapSceneChanger : MonoBehaviour
{
    public string newScene;
    public bool inUse = true;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(inUse == true){
        SceneManager.LoadScene(newScene,LoadSceneMode.Single);
        }
    }
}
