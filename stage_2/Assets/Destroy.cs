using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int Score; //敵を倒すとえられる点数
    private ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
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
        sm.AddScore(Score);
    }
}
