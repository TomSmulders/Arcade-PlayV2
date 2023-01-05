using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 15f;
    public float liveTimeBullet;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, liveTimeBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(transform.right * speed * Time.deltaTime);
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

