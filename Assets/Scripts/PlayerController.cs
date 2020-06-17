using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//移動管理

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float SPEED = 3.0f;
    private Rigidbody2D rigidBody;
    private Vector2 inputAxis;
    void Start()
    {
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
        rigidBody.velocity = inputAxis.normalized * SPEED;
        var currentPosi = this.transform.position.x;
    }
}
