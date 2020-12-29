using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bar : MonoBehaviour
{
    public void OnTouch( BaseEventData arg )
    {
        PointerEventData _event = arg as PointerEventData;

        // 押されているときの処理
        var transform = GetComponent<RectTransform>();
        var position = transform.position; // 今のtransformの座標を取得
        position.x = _event.position.x;         // ドラッグされている場所を代入
        transform.position = position;     // transformに座標を反映
    }
}
