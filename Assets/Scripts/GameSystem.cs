using System.Collections;
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
    public ScenesManager scenesManager;
    int HPValue;
    int aroundSomeone;
    
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

        if (scenesManager.c <= 0)
        {
            messageController.TextStart();
        }
        if (messageController.textEndFlag)
        {
            playerController.canMove = true;
        }
    }
}
