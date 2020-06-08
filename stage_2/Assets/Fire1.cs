using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire1 : MonoBehaviour
{
    GameObject Player;   
    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);

        if (transform.position.y < -5.1f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.Player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //半径
        float r2 = 1.0f; //プレイヤの半径

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}
