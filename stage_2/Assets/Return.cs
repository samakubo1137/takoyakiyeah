using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Return : MonoBehaviour
{
    int b;
    private Text Score;
    // Start is called before the first frame update
    void Start()
    {
        b = ScoreManager.getA();
        print(b);
        Score = GameObject.Find("Score").GetComponent<Text>();
        Score.text = "Score:" + b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
