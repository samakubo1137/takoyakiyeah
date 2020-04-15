using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //アイテムにアタッチする前提です。(タグ付けもしておくとなお良し)

    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter2D(Collider2D hit)
    {
        // 接触対象がプレイヤーかどうかを判断する
        if (hit.CompareTag("ここにプレイヤーのタグを入力する"))
        {
            // アイテムをDestroy、取ったように見せかける
            Destroy(gameObject);

            //プレイヤーがアイテム(バケツ？)に触れる＝水ゲージの回復
            //アイテムを取得することにより水回復の処理


        }
    }
}
