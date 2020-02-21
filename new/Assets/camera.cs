using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        Vector3 PlayerPos = Player.transform.position;

        transform.position = new Vector3(PlayerPos.x, 0, -10);
    }
}

