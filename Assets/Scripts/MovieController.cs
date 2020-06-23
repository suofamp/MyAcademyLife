using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieController : MonoBehaviour
{
    public MoviePlayerUI MoviePlayerUI;
    public PlayerManager playerManager;
    public MessageController messageController;
    public ScenesManager scenesManager;
    int HPValue;
    int aroundSomeone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPValue = playerManager.HPValue;
        //aroundSomeone = playerManager.distance(someonePointer);
        MoviePlayerUI.updateUI(HPValue);
        if (scenesManager.c <= 0)
        {
            messageController.TextStart();
            if (messageController.textEndFlag)
            {
                scenesManager.fadeOutStart();
            }
        }
        //messageController.IsTextPush = false;
    }
}
