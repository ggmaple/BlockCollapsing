using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    //ブロックを追加する場所(GameObject)
    [SerializeField]
    private RectTransform blocks_;

    /// ブロックの元になるPrefab
    [SerializeField]
    private GameObject blockPrefab_;

    void Start()
    {
        // 横5個なので左に2個分ずらして中央に合わせる
        int centering = 5 / 2;

        // 5x5個ブロックを用意する
        for ( int y = 0; y < 5; ++y ) {
            for ( int x = 0; x < 5; ++x ) {
                // InstantiateでPrefabをコピーしたGameObjectを作る
                var block = Instantiate<GameObject>( blockPrefab_ );
                // 新規GameObjectの親を設定されたGameObjectにする
                block.transform.SetParent( blocks_, false );

                // 座標を調整する
                var transform = block.GetComponent<RectTransform>();
                var rect = transform.rect;      // ブロックの大きさ

                // xは0が真ん中
                //  -1*widthでブロック1つ分左、1*widthでブロック1つ分右に
                // yは0が一番上、0だと壁にめり込むので60下に下げる
                //  そこから-width毎に下にずれる
                transform.anchoredPosition = new Vector2(
                        (x - centering) * rect.width,
                        -y * rect.height - 60 );
            }
        }
    }
}
