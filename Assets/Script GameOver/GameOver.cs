using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text finalScoreText; // �Q�[���I�[�o�[��ʂŃX�R�A��\������e�L�X�g

    void Start()
    {
        // �X�R�A��ǂݍ���ŕ\��
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        if (finalScoreText != null)
        {
            finalScoreText.text = "Final Score: " + finalScore;
        }
    }
}
