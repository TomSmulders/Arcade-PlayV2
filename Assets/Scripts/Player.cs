using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;

    Animator anim;

    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage()
    {
        Debug.Log("hit the enemy");
        health--;
        if (health <= 0)
        {
            die();
        }
    }

    void die()
    {
        Debug.Log("die");
        anim.SetBool("PlayerDie", true);
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
