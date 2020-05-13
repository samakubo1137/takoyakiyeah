using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionCheck : MonoBehaviour
{
    //範囲内に壁がある
    public bool isOn = false;

    private string groundtag = "Ground";
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
        if(collision.tag==groundtag)
        {
            isOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag==groundtag)
        {
            isOn = false;
        }
    }
}
