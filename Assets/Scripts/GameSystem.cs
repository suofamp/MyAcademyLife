﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public SomeoneGenerator someoneGenerator;
    public SomeonePointer someonePointer;
    public PlayerController playerController;
    public PlayerUI playerUI;
    public PlayerManager playerManager;
    public MessageController messageController;
    int HPValue;
    int aroundSomeone;
    bool IsTextPush = false;
    // Start is called before the first frame update
    void Start()
    {
        someoneGenerator.SetUp(someonePointer);
    }

    // Update is called once per frame
    void Update()
    {
        
        HPValue = playerManager.HPValue;
        aroundSomeone = playerManager.distance(someonePointer);
        playerUI.updateUI(HPValue , aroundSomeone);
        playerManager.Damage();
        
        if (Input.GetMouseButtonDown(0))
        {
            PushText();
        }
        messageController.TextUpdate(IsTextPush);
        IsTextPush = false;
    }

    public void PushText()
    {
        this.IsTextPush = true;
    }
}
