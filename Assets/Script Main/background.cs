using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float scrollSpeed = 2f; // スクロール速度
    public float resetPositionX = -17f; // リセット位置
    public float startPositionX = 17f; // 開始位置

    void Update()
    {
        // オブジェクトを左に移動
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // オブジェクトがリセット位置を過ぎたら元の位置に戻す
        if (transform.position.x < resetPositionX)
        {
            Vector3 newPos = new Vector3(startPositionX, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
