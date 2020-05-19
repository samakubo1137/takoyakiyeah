using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のプレハブ

    //変数定義
    public float flap = 1000f;
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;

    // Use this for initialization
    void Start()
    {
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

        //キーボード操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }
        else
        {
            direction = 0f;
        }


        //キャラのy軸のdirection方向にscrollの力をかける
        rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //ジャンプ判定
        if (Input.GetKeyDown("space") && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;
        }

        // -----弾発射処理-----
        if (Input.GetKeyDown(KeyCode.A))
        { // Aを押された瞬間
          // GameObject型ローカル変数を宣言 (生成したインスタンスを格納する)
            GameObject obj;
            // 弾プレハブのインスタンスを生成し、変数objに格納
            obj = Instantiate(bulletPrefab);
            // 弾インスタンスの座標にプレイヤーの座標をセット
            obj.transform.position = transform.position;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClaerScene");
    }
}
