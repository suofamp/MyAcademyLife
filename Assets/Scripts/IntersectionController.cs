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

    [SerializeField] List<float> north;
    [SerializeField] List<float> northEast;
    [SerializeField] List<float> east;
    [SerializeField] List<float> southEast;
    [SerializeField] List<float> south;
    [SerializeField] List<float> southWest;
    [SerializeField] List<float> west;
    [SerializeField] List<float> northWest;

    List<List<float>> lines = new List<List<float>>();

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        position = this.transform.position;
        colliderSize = boxCollider.size;
        Debug.Log(colliderSize.x + " " + colliderSize.y);
        Debug.Log(position.x + " " + position.y);
        lines.Add(north);//0
        lines.Add(northEast);//1
        lines.Add(east);//2
        lines.Add(southEast);//3
        lines.Add(south);//4
        lines.Add(southWest);//5
        lines.Add(west);//6
        lines.Add(northWest);//7
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<SomeoneMovingController>())
        {
            someoneMovingController = collision.gameObject.GetComponent<SomeoneMovingController>();
            Debug.Log("in" + collision.name);
            int nextDirection = 0;
            int currentDirection = 0;
            currentDirection = someoneMovingController.direction;
            nextDirection = arrowedDirection[Random.Range(0, arrowedDirection.Count)];
            while (nextDirection == currentDirection - 4 || nextDirection == currentDirection + 4)
            {
                nextDirection = arrowedDirection[Random.Range(0, arrowedDirection.Count)];
            }
            //Debug.Log(arrowedDirection[nextDirection]);
            //someoneMovingController.direction = arrowedDirection[nextDirection];
            //nextDirection = 6;
            someoneMovingController.direction = nextDirection;
            someoneMovingController.root = lines[nextDirection][Random.Range(0, lines[nextDirection].Count)];
            Debug.Log(someoneMovingController.root);
            someoneMovingController.turnFlag = true;
        }
        
    }

    //曲がるかどうか。曲がる場合、目当てのルートまで行き、曲がって終わり
    //曲がらない場合、突き当たりまでいって曲がり、目当てのルートに行き、曲がって終わり
    private void CheckingTurn(int currentDirection, int nextDirection)
    {
        float x, y = 0;
        switch(Mathf.Abs(currentDirection % 4 - nextDirection % 4))
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
    }

    private void DecisionRoot(int nextDirection)
    {
        float x, y = 0;
        switch (nextDirection)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                //x = verticalLine[Random.Range(0, verticalLine.Count)];
                y = position.y - colliderSize.y / 2 - 0.5f;
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default:
                break;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //someoneMovingController.turnFlag = false;
    }
}
