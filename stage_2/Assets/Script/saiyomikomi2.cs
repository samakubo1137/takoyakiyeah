using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class saiyomikomi2 : MonoBehaviour
{
    string stage2;
 
    // Start is called before the first frame update
    void Start()
    {
        stage2 = SceneManager.GetActiveScene().name;
    }
 
    // Update is called once per frame
    void Update()
    {
 
    }
 
    public void RetryButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(stage2);
    }


}
