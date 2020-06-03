using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//クラス名の上に追加してください


public class saiyomikomi : MonoBehaviour
{
    string waaa;

    // Start is called before the first frame update
    void Start()
    {
        waaa = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(waaa);
    }

}
