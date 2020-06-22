using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public string SceneName;
    public PlayerManager playerManager;
    bool fadeInFlag = false;
    bool dadeOutFlag = false;

    private void Update()
    {
        
    }

    public void ChangeScene()
    {
        Debug.Log(playerManager.HPValue);
        SceneManager.sceneLoaded += pathValue;
        SceneManager.LoadScene(SceneName);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(playerManager.HPValue);
        SceneManager.sceneLoaded += pathValue;
        SceneManager.LoadScene(SceneName);
    }

    void pathValue(Scene scene,LoadSceneMode mode)
    {
        var pathHP = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        pathHP.HPValue = playerManager.HPValue;
        SceneManager.sceneLoaded -= pathValue;
    }
}
