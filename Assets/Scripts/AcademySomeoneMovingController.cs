using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AcademySomeoneMovingController : MonoBehaviour
{
    public List<(float, float)> wayPoints = new List<(float, float)>();
    [SerializeField] public List<int> test = new List<int>();
    public int destroy;
    public Tilemap areaWall;
    public float speed;
    Vector2 position;
    Transform someoneTransform;
    private Vector2 currentPosi;
    private int nextWayPoint;
    private int status;//0:set, 1:moving, 2:arrived, 3:finish
    private int direction;
    private float[,] directionNum = new float[4, 2] {
        {1, 1 },
        {1, -1 },
        {-1, -1 },
        {-1, 1 }
    };//0:NE, 1:SE, 2:SW, 3:NW
    private Vector3Int tileCheckXC;//左右
    private Vector3Int tileCheckXF;
    private Vector3Int tileCheckYC;//上下
    private Vector3Int tileCheckYF;
    private float xDiff;
    private float yDiff;
    private int XY;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        someoneTransform = this.transform;
        currentPosi = position;
        nextWayPoint = 0;
        status = 0;
        direction = 0;
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        //Debug.Log(status);
        switch (status)
        {
            case 0:
                set();
                break;
            case 1:
                moving();
                break;
            case 2:
                arrived();
                break;
            case 3:
                finish();
                break;
            default:
                break;
        }

        someoneTransform.position = position;
    }

    private void set()
    {
        if(currentPosi.x >= wayPoints[nextWayPoint].Item1)//左へ
        {
            if(currentPosi.y >= wayPoints[nextWayPoint].Item2)//下へ
            {
                direction = 2;
            }
            else//上へ
            {
                direction = 3;
            }
        }
        else//右へ
        {
            if (currentPosi.y >= wayPoints[nextWayPoint].Item2)//下へ
            {
                direction = 1;
            }
            else//上へ
            {
                direction = 0;
            }
        }
        Debug.Log(wayPoints[nextWayPoint].Item1 + " " + wayPoints[nextWayPoint].Item2);
        status = 1;
    }

    private void moving()
    {
        if (Mathf.Round(position.x) == wayPoints[nextWayPoint].Item1 && Mathf.Round(position.y) == wayPoints[nextWayPoint].Item2)
        {
            status = 2;
            return;
        }

        if (direction == 0 || direction == 1)
        {
            tileCheckXC.x = Mathf.RoundToInt(position.x) + 1;
            tileCheckXF.x = Mathf.RoundToInt(position.x) + 1;
        }
        else
        {
            tileCheckXC.x = Mathf.RoundToInt(position.x) - 1;
            tileCheckXF.x = Mathf.RoundToInt(position.x) - 1;
        }
        tileCheckXC.y = Mathf.CeilToInt(position.y);
        tileCheckXF.y = Mathf.FloorToInt(position.y);
        tileCheckXC.z = 0;
        tileCheckXF.z = 0;

        if(direction == 0 || direction == 3)
        {
            tileCheckYC.y = Mathf.RoundToInt(position.y) + 1;
            tileCheckYF.y = Mathf.RoundToInt(position.y) + 1;
        }
        else
        {
            tileCheckYC.y = Mathf.RoundToInt(position.y) - 1;
            tileCheckYF.y = Mathf.RoundToInt(position.y) - 1;
        }
        tileCheckYC.x = Mathf.CeilToInt(position.x);
        tileCheckYF.x = Mathf.FloorToInt(position.x);
        tileCheckYC.z = 0;
        tileCheckYF.z = 0;

        if(areaWall.HasTile(tileCheckXC) && areaWall.HasTile(tileCheckXF) && areaWall.HasTile(tileCheckYC) && areaWall.HasTile(tileCheckYF))
        {
            Debug.Log("i cant move");
            return;
        }else if (areaWall.HasTile(tileCheckXC) || areaWall.HasTile(tileCheckXF))
        {
            Debug.Log(wayPoints[nextWayPoint].Item1 + " " + wayPoints[nextWayPoint].Item2 +" there is a wall.(EW)" + tileCheckXC + " " + tileCheckXF);
            position.y += speed * directionNum[direction, 1];
            return;
        }else if(areaWall.HasTile(tileCheckYC) || areaWall.HasTile(tileCheckYF))
        {
            Debug.Log(wayPoints[nextWayPoint].Item1 + " " + wayPoints[nextWayPoint].Item2 + " there is a wall.(NS) " + tileCheckYC + " " + tileCheckYF);
            position.x += speed * directionNum[direction, 0];
            return;
        }

        if(Mathf.Round(position.x) == wayPoints[nextWayPoint].Item1 && Mathf.Round(position.y) == wayPoints[nextWayPoint].Item2)
        {
            return;
        }else if(Mathf.Round(position.x) == wayPoints[nextWayPoint].Item1)
        {
            position.y += speed * directionNum[direction, 1];
            return;
        }else if(Mathf.Round(position.y) == wayPoints[nextWayPoint].Item2)
        {
            position.x += speed * directionNum[direction, 0];
            return;
        }

        xDiff = Mathf.Abs(Mathf.Round(position.x) - Mathf.Round(wayPoints[nextWayPoint].Item1));
        yDiff = Mathf.Abs(Mathf.Round(position.y) - Mathf.Round(wayPoints[nextWayPoint].Item2));

        XY = Random.Range(0, 2);
        if (XY == 0)
        {
            position.x += speed * directionNum[direction, 0];
        }
        else if(XY == 1)
        {
            position.y += speed * directionNum[direction, 1];
        }
    }

    private void arrived()
    {
        if(nextWayPoint < wayPoints.Count - 1)
        {
            Debug.Log("arrived");
            currentPosi = position;
            nextWayPoint++;
            status = 0;
        }
        else
        {
            status = 3;
        }
    }

    private void finish()
    {
        switch (destroy)
        {
            case 0://上へ
                position.y += speed;
                break;
            case 1://右へ
                position.x += speed;
                break;
            case 2://下へ
                position.y -= speed;
                break;
            case 3://左へ
                position.x -= speed;
                break;
            default:
                break;
        }
    }
}
