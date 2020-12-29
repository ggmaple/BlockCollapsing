using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ブロックに関する処理
public class Block : MonoBehaviour
{
    //ボールにぶつかった時の処理
    void OnCollisionExit2D()
    {
        // ブロックのGameObjectを消す
        Destroy( gameObject );
    }
}
