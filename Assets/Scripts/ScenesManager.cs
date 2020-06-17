using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public PlayerManager playerManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(playerManager.HPValue);
        SceneManager.sceneLoaded += pathValue;
        SceneManager.LoadScene("NextArea");
    }

    void pathValue(Scene scene,LoadSceneMode mode)
    {
        var pathHP = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        pathHP.HPValue = playerManager.HPValue;
        SceneManager.sceneLoaded -= pathValue;
    }
}
