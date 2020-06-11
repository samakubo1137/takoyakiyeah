using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //変数定義
    public float flap = 1000f;
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;
    public GameObject bulletPrefab; // 弾のプレハブ
    public water sc;
    

    

    // Use this for initialization
    void Start()
    {
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
        sc = GetComponent<water>();
    }


    // Update is called once per frame
    void Update()
    {

        //キーボード操作
        float key = 0;

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            direction = 1f;
            key = 0.25f;
        } 
        else if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            direction = -1f;
            key = -0.25f;
        } 
        else
        {
            direction = 0f;
        }


        if (sc.Water > 0)
        {

            // -----弾発射処理-----
            if (Input.GetKey(KeyCode.A))
            { // 左クリックを押された瞬間
              // GameObject型ローカル変数を宣言 (生成したインスタンスを格納する)
                GameObject obj;
                // 弾プレハブのインスタンスを生成し、変数objに格納
                obj = Instantiate(bulletPrefab);
                // 弾インスタンスの座標にプレイヤーの座標をセット
                obj.transform.position = transform.position + new Vector3(0.0f, +0.5f, 0.0f);
            }
        }
    
       if(key != 0)
        {
            transform.localScale = new Vector3(key, 0.25f, 0.25f);
        }

                //キャラのy軸のdirection方向にscrollの力をかける
                rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //ジャンプ判定
        if (Input.GetKeyDown("space") && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;

        }
        




    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }

        if (other.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("ClaerScene");
        }

        if (other.gameObject.tag == "Dead")
        {
            SceneManager.LoadScene("GameOver");
        }

    }    
}

