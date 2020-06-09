using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Score").GetComponent<Text>();
        Score.text = "Score:" + score;
    }
    //sucoreを増加させる
    public void AddScore(int amount)
    {
        score += amount;
        Score.text = "Score:" + score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
