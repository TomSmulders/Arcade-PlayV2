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
    public SpriteRenderer sprite;

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

    public IEnumerator DamageFlicker()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.15f);
        sprite.color = Color.white;
    }

    public void takeDamage()
    {
        hp--;
        StartCoroutine(DamageFlicker());
        if (hp <= 0)
        {
            die();

        }
    }

    void die()
    {
        anim.SetBool("IsAlive", false);
        GetComponent<BoxCollider2D>().enabled = false;
        Score.instance.combo++;
        Score.instance.AddScore(10, transform);
        Destroy(gameObject, 0.5f);
    }

}
