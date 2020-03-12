using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Player;

    private void Start()
    {
      
    }

    private void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, 5, -10);
    }
}

