using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int enemyHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            enemyHP -= 1;
            Destroy(other.gameObject);

            //HPが０になったら敵オブジェクト破壊
            if (enemyHP == 0)
            {
                Destroy(transform.root.gameObject);

            }
        }
    }
}
