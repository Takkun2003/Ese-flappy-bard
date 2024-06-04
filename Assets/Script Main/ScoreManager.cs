using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // 現在のスコア
    public Text scoreText; // スコアを表示するUIテキスト
    public float interval = 10.0f; // ポイントを加算する間隔（秒）
    public int pointsPerInterval = 100; // 10秒ごとに加算するポイント

    private float timer = 0.0f;

    void Start()
    {
        // スコアテキストの初期化
        UpdateScoreText();
        //DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // タイマーを更新
        timer += Time.deltaTime;

        // 一定時間が経過したらスコアを加算
        if (timer >= interval)
        {
            AddScore(pointsPerInterval);
            timer = 0.0f; // タイマーをリセット
        }
    }

    void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("FinalScore", score);
        PlayerPrefs.Save();
    }
}
