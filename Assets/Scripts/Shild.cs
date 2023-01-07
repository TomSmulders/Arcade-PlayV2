using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shild : MonoBehaviour
{
    private GameObject SpaceShip;
    public float speed;
    public float randomOffset = 0.5f;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.enabled = false;
            PlayerHealth col = collision.gameObject.GetComponent<PlayerHealth>();

            col.StartCoroutine(col.turnOffShild());
        }
    }


}
