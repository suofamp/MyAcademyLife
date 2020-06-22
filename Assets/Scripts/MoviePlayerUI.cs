using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoviePlayerUI : MonoBehaviour
{
    public Text HP;
    //public Text around;

    public void updateUI(int HPValue)
    {
        updateHP(HPValue);
        //updateAround(aroundSomeone);
    }

    void updateHP(int HPValue)
    {
        HP.text = string.Format("HP:{0}", HPValue);
    }
    /*
    void updateAround(int aroundSomeone)
    {
        around.text = string.Format("周囲：{0}人", aroundSomeone);
    }
    */
}
