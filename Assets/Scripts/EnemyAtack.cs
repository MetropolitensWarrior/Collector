using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    private Transform player;
    private Vector3 diraction;
    public float speed;
    public float attackRange;
    public float distanceToPlayer;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer=Vector3.Distance(transform.position, player.position);
        if(distanceToPlayer <= attackRange)
        {
            diraction=(player.position - transform.position).normalized;

            transform.Translate(diraction * Time.deltaTime * speed);
        }
    }
}
