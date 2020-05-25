using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float speed;
    public float gravity;


    
    //public EnemyCollisionCheck checkCollision;


    private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    private bool rightTleftF = false;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
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
        if (sr.isVisible)
        {
            //if(checkCollision.isOn)
            //{
            //    rightTleftF = !rightTleftF; //逆にする
            //}
            int xVector = -1;
            if (rightTleftF)
            {
                xVector = 1;
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);

            }
            rb.velocity = new Vector2(xVector * speed, -gravity);









        }
    }
}

    

