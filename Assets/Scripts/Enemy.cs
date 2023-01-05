using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour 
{
    public int hp = 2;


    Animator anim;

    public float speed;
    public Transform target;
    private bool spawned = true;
    private bool enemyCanShoot = true;
    public float interval;

    public GameObject EnemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        //enemy movement
        if (transform.position.x != target.position.x)
        {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        
        //enemy shooting invoke
        if (enemyCanShoot)
        {
        Invoke("EnemyShoot", interval);
            enemyCanShoot = false;
        }

    }

    //enemy shooting method
    private void EnemyShoot()
    {
        GameObject spawnedBullet = Instantiate(EnemyBullet, transform.position, Quaternion.identity);
        enemyCanShoot=true;
    }

    public void takeDamage()
    {
        Debug.Log("hit the enemy");
        hp--;
        if (hp <= 0)
        {
            die();

        }
    }

    void die()
    {
        Debug.Log("die");
        anim.SetBool("IsAlive", false);
        GetComponent<BoxCollider2D>().enabled = false;
        Score.instance.AddScore(10);
        Destroy(gameObject, 0.5f);
    }

}
