using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossnougoki : MonoBehaviour
{

    private float speed = 3f;
    private float rotationSmooth = 1f;

    private Transform Player;

    private float changeTargetSqrDistance = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //playerの方向を向く
        Quaternion targetRotation = Quaternion.LookRotation(Player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

        

        // 前方に進む
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    //public Vector3 GetRandomPositionOnLevel()
    //{
    //    float levelSize = 55f;
    //    return new Vector3(Random.Range(-levelSize, levelSize), 0, Random.Range(-levelSize, levelSize));
    //}

}

