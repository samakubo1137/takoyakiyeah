using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HP : MonoBehaviour
{
    public int hp = 3;//hp
    private Slider _slider;//Sliderの値を代入する
    public GameObject slider;//体力ゲージに指定するSlider

    void Start()
    {
        _slider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hp -= 1;
        }
        if (collision.gameObject.tag == "Boss")
        {
            hp -= 1;
        }

        if (collision.gameObject.tag == "Trap")
        {
            hp -= 1;
        }

        if (hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

   
}
