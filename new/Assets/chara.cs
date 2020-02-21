using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara : MonoBehaviour
{
    private bool Attack = false;
    private Animator animator;
    public float flap = 1000f;
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
       


        //キーボード操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Ran", false);
            direction = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
            animator.SetBool("Ran", false);
        }
        else
        {
            animator.SetBool("Ran", true);
            direction = 0f;
        }

        //アタック操作



        //キャラのy軸のdirection方向にscrollの力をかける
        rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //ジャンプ判定
        if (Input.GetKeyDown("space") && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;
            animator.SetBool("Jump", true);
        }


    }

    void FixedUpdate()
    {
        //  エンターキーが押されたら攻撃フラグを立てる
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetTrigger("Attack");
            Attack = true;

        }

    }
        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                jump = false;
            }
        }
    
}
