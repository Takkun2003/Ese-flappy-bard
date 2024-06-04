using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    public string GameOver = "GameOver"; // �Q�[���I�[�o�[�V�[���̖��O
    public Text finalScoreText; // �Q�[���I�[�o�[��ʂŃX�R�A��\������e�L�X�g

    public float jumpForce = 5f; // �����W�����v�����
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ��W�����v
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // ������̗͂������ăW�����v
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("��������");
        // �X�R�A��ۑ�
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.SaveScore();
        }
        // �Q�[���I�[�o�[�V�[���ɐ؂�ւ�
        SceneManager.LoadScene(GameOver);
    }

}
