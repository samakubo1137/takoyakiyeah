﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class water : MonoBehaviour
{
    public int Water = 100;
    private Slider _slider;
    public GameObject slider;
    private AudioSource sound01;

    void Start()
    {
        _slider = slider.GetComponent<Slider>();
        sound01 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Water > 0)
        {


            if (Input.GetKey(KeyCode.A))
            {
                Water -= 1;
                Debug.Log("water");
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                sound01.PlayOneShot(sound01.clip);
            }
        }
       

        _slider.value = Water;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Item")
        {
            Water += 20;
        }

       
       
    }





}

