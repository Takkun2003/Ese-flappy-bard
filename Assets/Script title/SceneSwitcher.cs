using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // �V�[������ݒ肷��
    public string Main = "Main"; // �f�t�H���g�Őݒ肷��ꍇ

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
    public void OnStartButtonClicked()
    {
        if (!string.IsNullOrEmpty(Main))
        {
            SceneManager.LoadScene(Main);
        }
        else
        {
            Debug.LogError("�V�[�������ݒ肳��Ă��܂���B");
        }
    }
}