using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class muteki : MonoBehaviour
{
    private bool isDamaged = false; //敵に当たったか

    // Use this for initialization
    void Start()
    {
        isDamaged = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //ダメージを受けた時の処理
        if (isDamaged)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, level);
        }
    }
}