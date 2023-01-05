using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 15f;
    public float liveTimeBullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * -speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.takeDamage();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
