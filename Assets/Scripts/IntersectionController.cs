using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionController : MonoBehaviour
{
    SomeoneMovingController someoneMovingController;
    BoxCollider2D boxCollider;
    Vector2 colliderSize;
    Vector2 position;
    //[SerializeField] int[] arrowedDirection;//0:N 1:NE 2:E 3:SE 4:S 5:SW 6:W 7:NW
    [SerializeField] List<int> arrowedDirection;
    [SerializeField] List<float> verticalLine;
    [SerializeField] List<float> horizontalLine;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        position = this.transform.position;
        colliderSize = boxCollider.size;
        Debug.Log(colliderSize.x + " " + colliderSize.y);
        Debug.Log(position.x + " " + position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<SomeoneMovingController>())
        {
            someoneMovingController = collision.gameObject.GetComponent<SomeoneMovingController>();
            Debug.Log("in" + collision.name);
            int nextDirection = 0;
            nextDirection = Random.Range(0, arrowedDirection.Count);
            while (arrowedDirection[nextDirection] == someoneMovingController.direction - 4 || arrowedDirection[nextDirection] == someoneMovingController.direction + 4)
            {
                nextDirection = Random.Range(0, arrowedDirection.Count);
            }
            Debug.Log(arrowedDirection[nextDirection]);
            someoneMovingController.direction = arrowedDirection[nextDirection];
        }
        
    }/*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("in");
    }*/
}
