using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water : MonoBehaviour
{
    float _water = 100;
    Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

    }
    

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _water -= -5;
        }

    }

    

}

