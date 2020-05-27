using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroy : MonoBehaviour
{
    //private int count;

    // Start is called before the first frame update
    //private void Start()
    //{
    //    count = 0;
    //}

    void OnParticleCollision(GameObject ogj)
    {
        Debug.Log("衝突");
    }
    // Update is called once per frame
    void Update()
    {

    }

    //private void OnParticleCollision(GameObject other)
    //{
    //    count++;
    //}

    //public int Count
    //{
    //    get { return count; }
    //    private set { count = value; }
    //}
    
}

