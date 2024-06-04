using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float scrollSpeed = 2f; // �X�N���[�����x
    public float resetPositionX = -17f; // ���Z�b�g�ʒu
    public float startPositionX = 17f; // �J�n�ʒu

    void Update()
    {
        // �I�u�W�F�N�g�����Ɉړ�
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // �I�u�W�F�N�g�����Z�b�g�ʒu���߂����猳�̈ʒu�ɖ߂�
        if (transform.position.x < resetPositionX)
        {
            Vector3 newPos = new Vector3(startPositionX, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
