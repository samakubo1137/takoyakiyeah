using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water : MonoBehaviour
{

    Slider _slider;
    void Start()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _water = 100;
    void Update()
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (Input.GetKey(KeyCode.A))
            {
                _water -= -5;
            }


            _slider.value = _water;
        }
    }



}

