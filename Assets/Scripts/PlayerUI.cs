using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//UI管理

public class PlayerUI : MonoBehaviour
{
    public Text HP;
    public Text around;

    public void updateUI(int HPValue , int aroundSomeone)
    {
        updateHP(HPValue);
        updateAround(aroundSomeone);
    }

    void updateHP(int HPValue)
    {
        HP.text = string.Format("HP:{0}", HPValue);
    }

    void updateAround(int aroundSomeone)
    {
        around.text = string.Format("周囲：{0}人", aroundSomeone);
    }
}
