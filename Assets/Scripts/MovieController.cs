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
    bool IsTextPush = false;
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
        if (Input.GetMouseButtonDown(0) && messageController.currentSentenceNum == 0)
        {
            scenesManager.ChangeScene();
        }
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
