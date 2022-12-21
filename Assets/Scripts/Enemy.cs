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

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        //Enemy spawning move to start position
        if (transform.position.x != target.position.x)
        {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }

    }


    public void takeDamage()
    {
        //Enemy takes damage
        hp--;
        if (hp <= 0)
        {
            die();
        }
    }

    void die()
    {
        //Enemy dies
        anim.SetBool("IsAlive", false);
        GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject, 0.5f);
    }

}
