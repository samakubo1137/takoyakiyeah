using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water : MonoBehaviour
{

    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _water = 100;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _water -= -5; 
        }

        // HPゲージに値を設定
        _slider.value = _water;
    }



}

