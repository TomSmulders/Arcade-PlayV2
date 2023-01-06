using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;


    Animator anim;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
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

    public void die()
    {
        Debug.Log("die");
        anim.SetBool("PlayerDie", true);
        GetComponent<BoxCollider2D>().enabled = false;
        Invoke("loadScene", 1);
    }

    void loadScene()
    {
        SceneManager.LoadScene(3);
    }


}
