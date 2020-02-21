using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    //発射する水にアタッチする前提のスクリプトです

    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数

    void Start()
    {
        score = 0;
        SetScore();   //初期スコアを代入して表示
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "人を消火した場合、ここに火のタグを入力する")
        {
            //score += ここにスコアを入力;
        }
        else if(yourTag == "必要なら障害物を消火した場合、そのタグを入力")
        {
            //score += ここにスコアを入力する;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }

}
