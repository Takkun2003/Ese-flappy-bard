using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // シーン名を設定する
    public string Main = "Main"; // デフォルトで設定する場合

    // ボタンがクリックされたときに呼び出されるメソッド
    public void OnStartButtonClicked()
    {
        if (!string.IsNullOrEmpty(Main))
        {
            SceneManager.LoadScene(Main);
        }
        else
        {
            Debug.LogError("シーン名が設定されていません。");
        }
    }
}