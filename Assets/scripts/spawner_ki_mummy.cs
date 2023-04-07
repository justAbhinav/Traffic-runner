using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_ki_mummy : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float delayTimer = 1f;

    public float maxEnemyLeft;
    public float maxEnemyRight;

    float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 spawnpos = new Vector3(Random.Range(maxEnemyLeft, maxEnemyRight), transform.position.y, transform.position.z);

            int i = Random.Range(0, 2);
            Instantiate(enemyPrefab[i], spawnpos, transform.rotation);
            timer = delayTimer;
        }
    }
}
