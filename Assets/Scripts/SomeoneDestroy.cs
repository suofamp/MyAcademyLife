using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeoneDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hoge");
        if (collision.gameObject.GetComponent<SomeoneMovingController>() || collision.gameObject.GetComponent<AcademySomeoneMovingController>())
        {
            Destroy(collision.gameObject);
        }
    }
}
