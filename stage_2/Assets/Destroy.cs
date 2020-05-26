using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        // 弾とエネミーオブジェクトを消滅させる
        Destroy(collider.gameObject);   // 弾オブジェクト消去
        Destroy(gameObject);            // 自オブジェクト消去
    }
}
