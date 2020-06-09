using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript: MonoBehaviour
{
    Rigidbody2D rd;
    public float Speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rd.velocity = new Vector2(transform.localScale.x * Speed, rd.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Vector2 temp = gameObject.transform.localScale;
            temp.x *= -1;
            gameObject.transform.localScale = temp;
        }
    }
}
