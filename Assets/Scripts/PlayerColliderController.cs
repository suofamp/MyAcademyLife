using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderController : MonoBehaviour
{
    public PlayerManager playerManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SomeoneMovingController>())
        {
            playerManager.cnt++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SomeoneMovingController>())
        {
            playerManager.cnt--;
        }
    }
}
