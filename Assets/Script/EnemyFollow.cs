using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{


    private GameObject player;
    private Transform playerpos;
    private Vector2 currentpos;

    public float EnemySpeed = 2f;



    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerpos = player.GetComponent<Transform>();
        currentpos = GetComponent<Transform>().position;
        EnemySpawner.finalenemy++;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, playerpos.position, EnemySpeed * Time.deltaTime);

        if (transform.position.x < playerpos.position.x)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            transform.localScale = new Vector2(1, 1);
        }
    }
}


