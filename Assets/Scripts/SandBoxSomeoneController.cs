using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandBoxSomeoneController : MonoBehaviour
{
    [SerializeField] float walk = 2.0f;
    [SerializeField] float dash = 10.0f;
    private Rigidbody2D rigidBody;
    private Vector2 inputAxis;
    private float speed;
    public bool canMove = false;
    void Start()
    {
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
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

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit");
        Vector2 hitPos;
        foreach (ContactPoint2D point in other.contacts)
        {
            hitPos = point.point;
            Debug.Log(hitPos);
        }

    }
}
