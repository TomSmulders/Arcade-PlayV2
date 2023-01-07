using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticals : MonoBehaviour
{
    private GameObject SpaceShip;
    public float speed;
    public float randomOffset = 0.5f;
    Vector3 dir;
    void Start()
    {
        SpaceShip = GameObject.Find("player");
        dir = (SpaceShip.transform.position - transform.position).normalized;
        dir.x = Random.Range(dir.x - randomOffset, dir.x + randomOffset);
        dir.y = Random.Range(dir.y - randomOffset, dir.y + randomOffset);
        Destroy(gameObject, 7);
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().die();
        }
    }
}
