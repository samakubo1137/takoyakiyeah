using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelth : MonoBehaviour
{

    private float hp = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //水に当たった時の処理
        if(collision.gameObject.tag=="Water")
        {
            Debug.Log("hit");
            hp -= 1;
        }

        //体力が０以下になった時の処理
        if(hp<=0)
        {
            Destroy(gameObject);　//ゲームオブジェクト破壊
        }

        
    }
    
}
