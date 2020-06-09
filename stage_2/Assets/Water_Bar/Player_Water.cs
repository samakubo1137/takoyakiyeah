using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Water : MonoBehaviour
{
    public int hp = 100;//SliderのMaxValueとValueはここの値に合わせます
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//体力ゲージに指定するSlider

    // Use this for initialization
    void Start()
    {
        _slider = slider.GetComponent<Slider>();//sliderを取得する
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;//スライダーとHPの紐づけ
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Item")
        {
            hp += 30;
        }

        //ゲージを減らして動作確認するためのものなのでゲーム内では使用しません
        if (other.gameObject.tag == "Damage")
        {
            hp -= 30;
        }
    }
}