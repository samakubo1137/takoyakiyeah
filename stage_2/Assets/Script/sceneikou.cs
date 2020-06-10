using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneikou : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        // マウスを左クリックした瞬間
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("BOSS");
        }
    }
}
