using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに落下させる
        transform.Translate(0.1f, 0f, 0);
        
        //画面買いに出たらオブジェクト消える
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }
    }
}
