using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeoneMovingController : MonoBehaviour
{
    public int direction;//0:N 1:NE 2:E 3:SE 4:S 5:SW 6:W 7:NW
    public bool turnFlag = false;
    private float[,] directionCo = new float[8, 2]{
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
        posi.x = xPosi + (0.01f * directionCo[direction,0]);
        posi.y = yPosi + (0.01f * directionCo[direction,1]);
        someoneTransform.position = posi;
        //Debug.Log(xPosi + " " + yPosi);
    }
}
