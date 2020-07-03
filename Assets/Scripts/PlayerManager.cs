using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//HP管理、敵との距離管理

public class PlayerManager : MonoBehaviour
{
    //PlayerController playerController;
    SomeonePointer someonePointer;
    public GameObject player;
    public int HPValue = 100;
    public int cnt = 0;
    float dist = 0.0f;
    float timer;
    List<(float, float)> someoneDist = new List<(float, float)>();
    /*
    public int distance(SomeonePointer someonePointer)
    {
        cnt = 0;
        someoneDist = someonePointer.someonePoints;
        Vector2 position = player.transform.position;
        for (int i = 0; i < someoneDist.Count; i++)
        {
            dist = Mathf.Sqrt(Mathf.Pow((someoneDist[i].Item1 - position.x), 2) + Mathf.Pow((someoneDist[i].Item2 - position.y), 2));
            if (dist <= 1.5)
            {
                cnt++;
            }
        }
        return cnt;
    }
    */

    public void Damage()
    {
        timer += Time.deltaTime;
        if (cnt >= 1)
        {
            if (timer >= (0.2 / ((float)cnt * (float)cnt)))
            {
                //Debug.Log("damaged");
                HPValue --;
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }

        if (HPValue <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}