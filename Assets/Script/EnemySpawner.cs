using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static int enemyno = 0;
    [SerializeField] private float spawnRadius = 7, time = 1.5f;
    Coroutine coroutine_;
    public static int finalenemy = 0;
    public GameObject[] Enemy;
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(SpawnEnemy());
        finalenemy = 0;

    }
    void Update()
    {
        if (finalenemy > 100)
        {
            StopAllCoroutines();
        }
        else if (finalenemy <= 100)
        {

            StartCoroutine(SpawnEnemy());

        }

    }

    // Update is called once per frame
    IEnumerator SpawnEnemy()
    {


        Vector2 spawnpos = GameObject.Find("Player").transform.position;
        spawnpos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(Enemy[Random.Range(0, Enemy.Length)], spawnpos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnEnemy());
        enemyno++;


    }


}
