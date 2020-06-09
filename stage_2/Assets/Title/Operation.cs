using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Operation : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene("OPERATION");
    }
}
