using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 15f;

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(transform.right * speed * Time.deltaTime);

        if (transform.position.x > 9)
        {
            Score.instance.combo = 0;
            Destroy(gameObject, 0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.takeDamage();
            Destroy(gameObject);
        }

    }
}

