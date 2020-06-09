using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage1 : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene("stage1"); //タイトルからステージ1へ遷移します
    }
}
