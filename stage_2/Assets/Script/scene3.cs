﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene3 : MonoBehaviour
{
    //　アイテムメニューを開くボタン
    [SerializeField]
    private GameObject itemButton;
    //　ゲーム再開ボタン
    [SerializeField]
    private GameObject reStartButton;
    //　アイテムメニューパネル
    [SerializeField]
    private GameObject itemPanel;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
        itemButton.SetActive(false);
        reStartButton.SetActive(true);
        itemPanel.SetActive(true);
    }

    public void ReStartGame()
    {
        itemPanel.SetActive(false);
        reStartButton.SetActive(false);
        itemButton.SetActive(true);
        Time.timeScale = 1f;

    }
        // Update is called once per frame
    void Update()
    {
        
    }
}
