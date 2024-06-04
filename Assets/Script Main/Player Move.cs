using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    public string GameOver = "GameOver"; // ゲームオーバーシーンの名前
    public Text finalScoreText; // ゲームオーバー画面でスコアを表示するテキスト

    public float jumpForce = 5f; // 鳥がジャンプする力
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // スペースキーが押されたらジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // 上向きの力を加えてジャンプ
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("当たった");
        // スコアを保存
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.SaveScore();
        }
        // ゲームオーバーシーンに切り替え
        SceneManager.LoadScene(GameOver);
    }

}
