using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionCheck : MonoBehaviour
{
    public bool isOn = false;

    private string wallTag = "Wall";
    private string enemyTag = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == wallTag || collision.tag == enemyTag)
        {
            isOn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == wallTag || collision.tag == enemyTag)
        {
            isOn = false;
        }
    }

}
