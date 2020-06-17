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
    }
}
