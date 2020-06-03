using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class water : MonoBehaviour
{
    public int Water = 100;
    private Slider _slider;
    public GameObject slider;

    void Start()
    {
        _slider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.A))
        {
            Water -= 1;
            Debug.Log("water");
        }

        _slider.value = Water;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Item")
        {
            Water += 5;
        }

        if (Water <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }





}

