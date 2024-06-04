using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // ���݂̃X�R�A
    public Text scoreText; // �X�R�A��\������UI�e�L�X�g
    public float interval = 10.0f; // �|�C���g�����Z����Ԋu�i�b�j
    public int pointsPerInterval = 100; // 10�b���Ƃɉ��Z����|�C���g

    private float timer = 0.0f;

    void Start()
    {
        // �X�R�A�e�L�X�g�̏�����
        UpdateScoreText();
        //DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // �^�C�}�[���X�V
        timer += Time.deltaTime;

        // ��莞�Ԃ��o�߂�����X�R�A�����Z
        if (timer >= interval)
        {
            AddScore(pointsPerInterval);
            timer = 0.0f; // �^�C�}�[�����Z�b�g
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
