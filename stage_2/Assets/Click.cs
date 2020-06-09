using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{   
    void Update()
    {
        // 左クリックしたら、効果音を鳴らす
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
    }
}
