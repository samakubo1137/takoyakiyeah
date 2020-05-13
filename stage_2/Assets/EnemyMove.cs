using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float speed;
    public float grabity;


    private Rigidbody2D rd = null;
    private SpriteRenderer sr = null;
    private bool rightTleftF = false;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.isVisible)
        {
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
            rd.velocity = new Vector2(xVector * speed, -grabity);









        }
    }
}

    

