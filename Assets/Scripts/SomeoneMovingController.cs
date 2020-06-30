using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeoneMovingController : MonoBehaviour
{
    public int direction;//0:N 1:NE 2:E 3:SE 4:S 5:SW 6:W 7:NW
    public int nextDirection;
    public bool turnFlag = false;
    public float rootY;
    public float rootX;
    public int turnDegree;
    public float[,] directionCo = new float[8, 2]{//x,y
        {0, 1},
        {0.71f, 0.71f},
        {1, 0},
        {0.71f, -0.71f},
        {0, -1},
        {-0.71f, -0.71f},
        {-1, 0},
        {-0.71f, 0.71f}
        };
    private Vector2 posi;
    Transform someoneTransform;
    float xPosi;
    float yPosi;

    // Start is called before the first frame update
    void Start()
    {
        someoneTransform = this.transform;
        posi = this.transform.position;
        xPosi = this.transform.position.x;
        yPosi = this.transform.position.y;
        //Debug.Log(xPosi+" " + yPosi);
    }

    // Update is called once per frame
    void Update()
    {
        xPosi = this.transform.position.x;
        yPosi = this.transform.position.y;
        if (turnFlag)
        {
            //Turning();
            CheckDirection();
        }
        else
        {
            posi.x = xPosi + (0.01f * directionCo[direction, 0]);
            posi.y = yPosi + (0.01f * directionCo[direction, 1]);
            //Debug.Log(xPosi + " " + yPosi);
        }

        someoneTransform.position = posi;
    }
    /*
    void Turning()
    {
        switch (direction)
        {
            case 0:
                if (yPosi < rootY)
                {
                    posi.y = yPosi + (0.01f * 1);
                    //Debug.Log("turning now");
                }else if(yPosi >= rootY && xPosi < rootX){

                }
                else
                {
                    turnFlag = false;
                }
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
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
    */
    void CheckDirection()
    {
        switch (direction % 4)
        {
            case 0://直角
                DecisionRootAtVertical();
                break;
            case 1:
                break;
            case 2://水平
                DecisionRootAtHorizontal();
                break;
            case 3:
                break;
            default:
                break;
        }
    }

    //xとy両方渡す
    //曲がるかどうかで四通り
    //方向で8通り
    private void DecisionRootAtVertical()
    {
        switch (Mathf.Abs(direction % 4 - nextDirection % 4))
        {
            case 0://直進
                if (directionCo[direction, 1] * (rootY - yPosi) > 0)
                {
                    posi.y = yPosi + (0.01f * directionCo[direction, 1]);
                    if (rootX > xPosi)
                    {
                        turnDegree = 1;
                    }
                    else if (rootX < xPosi)
                    {
                        turnDegree = -1;
                    }
                    else
                    {
                        turnDegree = 0;
                    }
                }
                else if (turnDegree * (rootX - xPosi) > 0)
                {
                    posi.x = xPosi + (0.01f * turnDegree);
                }
                else
                {
                    direction = nextDirection;
                    turnFlag = false;
                }
                break;
            case 1:
                break;
            case 2://直角に曲がる
                if (directionCo[direction, 1] * (rootY - yPosi) > 0)
                {
                    posi.y = yPosi + (0.01f * directionCo[direction, 1]);
                }
                else
                {
                    direction = nextDirection;
                    turnFlag = false;
                }
                break;
            case 3:
                break;
            default:
                break;
        }
    }

    private void DecisionRootAtHorizontal()
    {
        switch (Mathf.Abs(direction % 4 - nextDirection % 4))
        {
            case 0://直進
                if (directionCo[direction, 0] * (rootX - xPosi) > 0)
                {
                    posi.x = xPosi + (0.01f * directionCo[direction, 0]);
                    if(rootY > yPosi)
                    {
                        turnDegree = 1;
                    }
                    else if(rootY < yPosi)
                    {
                        turnDegree = -1;
                    }
                    else
                    {
                        turnDegree = 0;
                    }
                }
                else if (turnDegree * (rootY - yPosi) > 0)
                {
                    posi.y = yPosi + (0.01f * turnDegree);
                }
                else
                {
                    direction = nextDirection;
                    turnFlag = false;
                }
                break;
            case 1:
                break;
            case 2://直角に曲がる
                if (directionCo[direction, 0] * (rootX - xPosi) > 0)
                {
                    posi.x = xPosi + (0.01f * directionCo[direction, 0]);
                }
                else
                {
                    direction = nextDirection;
                    turnFlag = false;
                }
                break;
            case 3:
                break;
            default:
                break;
        }
    }
}
