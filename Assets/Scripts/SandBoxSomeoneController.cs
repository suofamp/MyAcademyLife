using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SandBoxSomeoneController : MonoBehaviour
{
    [SerializeField] float walk = 2.0f;
    [SerializeField] float dash = 10.0f;
    public Tilemap tilemap;
    private Rigidbody2D rigidBody;
    private Vector2 inputAxis;
    private float speed;
    public bool canMove = false;
    private Vector2 position;
    private float xPosi;
    private float yPosi;
    private Vector3Int nPosi;
    private Vector3Int ePosi;
    private Vector3Int wPosi;
    private Vector3Int sPosi;
    void Start()
    {
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rigidBody = GetComponent<Rigidbody2D>();
        position = this.transform.position;
    }

    void Update()
    {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
        position = this.transform.position;
        checkWall();
        if (!canMove)
        {
            if (Input.GetKey("left shift"))
            {
                speed = dash;
            }
            else
            {
                speed = walk;
            }
            inputAxis.x = Input.GetAxis("Horizontal");
            inputAxis.y = Input.GetAxis("Vertical");
            rigidBody.velocity = inputAxis.normalized * speed;
        }
    }

    private void checkWall()
    {
        xPosi = Mathf.Round(position.x);
        yPosi = Mathf.Round(position.y);
        nPosi.x = (int)xPosi;
        nPosi.y = (int)yPosi + 1;
        nPosi.z = 0;
        ePosi.x = (int)xPosi + 1;
        ePosi.y = (int)yPosi;
        ePosi.z = 0;
        wPosi.x = (int)xPosi - 1;
        wPosi.y = (int)yPosi;
        wPosi.z = 0;
        sPosi.x = (int)xPosi;
        sPosi.y = (int)yPosi - 1;
        sPosi.z = 0;
        Debug.Log("上" + tilemap.HasTile(nPosi) + "右" + tilemap.HasTile(ePosi) + "左" + tilemap.HasTile(wPosi) + "下" + tilemap.HasTile(sPosi));
    }
}
