
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class hp : MonoBehaviour
{
    public int HP = 3;//hp
    private Slider _slider;//Sliderの値を代入する
    public GameObject slider;//体力ゲージに指定するSlider

    void Start()
    {
        _slider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = HP;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            HP -= 1;
        }

        if (HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


}



