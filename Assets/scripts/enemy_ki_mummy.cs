using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ki_mummy : MonoBehaviour
{
    public float enemySpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * enemySpeed * Time.deltaTime);


        if(transform.position.y<-12)
            Destroy(this.gameObject);
    }

}
