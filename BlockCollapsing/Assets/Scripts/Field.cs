using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Field : MonoBehaviour
{
    /// ボールがこの領域から出た時の処理
    public void OnTriggerExit2D()
    {
        // 今のシーンを終わらせてGameシーンを読み込む
        SceneManager.LoadScene( "Game" );
    }
}
