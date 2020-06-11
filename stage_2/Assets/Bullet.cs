using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 変数宣言
    private float speed = 10.0f; // スピード
    private float time = 0.0f;  // 経過時間
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // -----移動処理-----
        // Transformコンポーネントからposition(座標)パラメータを取得
        Vector3 pos = transform.position;
        // 右に指定した速度で直進する
        pos.x += speed * Time.deltaTime;
        // Transformコンポーネントのpositionに変数posをセット
        transform.position = pos;

        // -----寿命処理-----
        // 前回のUpdate実行から経過した時間をtimeに加算
        time += Time.deltaTime;
        // 消滅処理
        if (time > 0.5f)
        { // 弾の経過時間が0.5秒より大きければ
            Destroy(gameObject);
        }
    }
}
