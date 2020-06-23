using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public ScenesManager scenesManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scenesManager.fadeOutStart();
    }
}
