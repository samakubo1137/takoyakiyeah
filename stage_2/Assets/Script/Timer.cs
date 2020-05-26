using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
        float countTime = 90;

        // Update is called once per frame
        void Update()
        {
            countTime -= Time.deltaTime;
            GetComponent<Text>().text = countTime.ToString("F2");
        　　
        　　if(countTime <= 0)
            {
            SceneManager.LoadScene("GameOver");
            }
        }

}
