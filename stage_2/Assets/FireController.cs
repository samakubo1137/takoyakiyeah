using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
       
       
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        // 弾とエネミーオブジェクトを消滅させる
        Destroy(collider.gameObject);   // 弾オブジェクト消去
        Destroy(gameObject);            // 自オブジェクト消去

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.06f, 0, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        



    }
}
