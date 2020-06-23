using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public string SceneName;
    public PlayerManager playerManager;
    public GameObject fadePref;
    SpriteRenderer spriteRenderer;
    bool fadeInFlag = true;
    bool fadeOutFlag = false;
    //public bool sceneChangeFlag = false;
    public float c = 1;

    private void Start()
    {
        spriteRenderer = fadePref.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (fadeInFlag)
        {
            c -= Time.deltaTime;
            Debug.Log(c);
            spriteRenderer.color = new Color(0, 0, 0, c);
        };
        if (c <= 0)
        {
            fadeInFlag = false;
        }

        if (fadeOutFlag)
        {
            c += Time.deltaTime;
            Debug.Log(c);
            spriteRenderer.color = new Color(0, 0, 0, c);
        };
        if(c >= 1)
        {
            fadeOutFlag = false;
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        Debug.Log(playerManager.HPValue);
        SceneManager.sceneLoaded += pathValue;
        SceneManager.sceneLoaded += fadeInStart;
        SceneManager.LoadScene(SceneName);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fadeOutFlag = true;
    }

    void pathValue(Scene scene,LoadSceneMode mode)
    {
        var pathHP = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        pathHP.HPValue = playerManager.HPValue;
        SceneManager.sceneLoaded -= pathValue;
        SceneManager.sceneLoaded -= fadeInStart;
    }

    void fadeInStart(Scene scene, LoadSceneMode mode)
    {
        fadeInFlag = true;
    }

    public void fadeOutStart()
    {
        fadeOutFlag = true;
    }
}
