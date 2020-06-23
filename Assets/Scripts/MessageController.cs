﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{

    public string[] sentences; // 文章を格納する
    [SerializeField] Text uiText;   // uiTextへの参照
    public GameObject MessageCanvas;

    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharDisplay = 0.05f;   // 1文字の表示にかける時間

    int currentSentenceNum = 0; //現在表示している文章番号
    private string currentSentence = string.Empty;  // 現在の文字列
    private float timeUntilDisplay = 0;     // 表示にかかる時間
    private float timeBeganDisplay = 1;         // 文字列の表示を開始した時間
    private int lastUpdateCharCount = -1;       // 表示中の文字数
    bool textStartFlag = false;
    public bool textEndFlag = false;
    public bool IsTextPush = false;
    /*
    void Start()
    {
        SetNextSentence();
    }
    */

    public void TextStart()
    {
        if (!textStartFlag)
        {
            MessageCanvas.SetActive(true);
            textStartFlag = true;
            SetNextSentence();
        }
    }

    void TextEnd()
    {
        if (!textEndFlag)
        {
            MessageCanvas.SetActive(false);
            textEndFlag = true;
        }
    }

    void Update()
    {
        if (textStartFlag && !textEndFlag)
        {
            if (Input.GetMouseButtonDown(0) && !IsTextPush)
            {
                IsTextPush = true;
            }
            // 文章の表示完了 / 未完了
            if (IsDisplayComplete())
            {
                //最後の文章ではない & ボタンが押された
                if (currentSentenceNum < sentences.Length && IsTextPush)
                {
                    SetNextSentence();
                }
                else if (currentSentenceNum >= sentences.Length && Input.GetMouseButtonDown(0))
                {
                    TextEnd();
                }
            }
            else
            {
                if (IsTextPush)
                {
                    timeUntilDisplay = 0; //※1
                }
            }

            //表示される文字数を計算
            int displayCharCount = (int)(Mathf.Clamp01((Time.time - timeBeganDisplay) / timeUntilDisplay) * currentSentence.Length);
            //表示される文字数が表示している文字数と違う
            if (displayCharCount != lastUpdateCharCount)
            {
                uiText.text = currentSentence.Substring(0, displayCharCount);
                //表示している文字数の更新
                lastUpdateCharCount = displayCharCount;
            }
            /*
            if(Input.GetMouseButtonDown(0) && currentSentenceNum >= sentences.Length && IsDisplayComplete())
            {
                TextEnd();
            }
            */
            IsTextPush = false;
        }
    }

    // 次の文章をセットする
    public void SetNextSentence()
    {
        currentSentence = sentences[currentSentenceNum];
        timeUntilDisplay = currentSentence.Length * intervalForCharDisplay;
        timeBeganDisplay = Time.time;
        currentSentenceNum++;
        lastUpdateCharCount = 0;
    }

    bool IsDisplayComplete()
    {
        return Time.time > timeBeganDisplay + timeUntilDisplay; //※2
    }
}