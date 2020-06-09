using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//クラス名の上に追加してください


public class saiyomikomi : MonoBehaviour
{
    string stage1;

    // Start is called before the first frame update
    void Start()
    {
        stage1 = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(stage1);
    }

}
