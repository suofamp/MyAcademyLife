using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcademySomeoneMovingController : MonoBehaviour
{
    public List<(float, float)> wayPoints = new List<(float, float)>();
    Vector2 position;
    Transform someoneTransform;
    private Vector2 currentPosi;
    private int currentWayPoint;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        someoneTransform = this.transform;
        currentPosi = position;
        currentWayPoint = -1;
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        if (currentPosi.x > wayPoints[currentWayPoint + 1].Item1)//左へ
        {
            if(currentPosi.y > wayPoints[currentWayPoint + 1].Item2)//下へ
            {
                position.y -= 0.01f;
            }
        }
    }
}
