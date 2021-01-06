using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bar : MonoBehaviour
{
    //タッチ入力
    public void OnTouch( BaseEventData arg )
    {
        PointerEventData _event = arg as PointerEventData;

        // 押されているときの処理
        var BarTransform = GetComponent<RectTransform>();
        var BarPosition = BarTransform.position; // 今のtransformの座標を取得
        BarPosition.x = _event.position.x;         // ドラッグされている場所を代入
        BarTransform.position = BarPosition;     // transformに座標を反映
    }

    //キー入力
    void Update(){
        var BarTrans = GetComponent<RectTransform>();
        var BarPos = BarTrans.position; // 今のtransformの座標を取得
 
        //左キーを入力すると左にBarが動く
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(BarPos.x >= 640){ //左壁まで
                BarTrans.Translate(-3.0f, 0f, 0f);
            }        　
        }
        //右キーを入力すると右にBarが動く
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(BarPos.x <= 1038){ // 右壁まで
                BarTrans.Translate(3.0f, 0f, 0f);
            }        　　       
        }
        
    }
}
