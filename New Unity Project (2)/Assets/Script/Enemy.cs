using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    Rigidbody2D rb;
    public int moveSpeed = -2;
   



    // Start is called before the first frame update
    void Start()
    {
        //GetComponentの処理をキャッシュしておく 
        rb = GetComponent<Rigidbody2D>();
       
    }

    

    void FixedUpdate()
    {
        //velocity: 速度 
        //X方向へmoveSpeed分移動させる 
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}


        


    

