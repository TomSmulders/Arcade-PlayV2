using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float dirX;
    float dirY;

    public float interval = 0.5f;
    bool canShoot = true;


    //bullet
    public GameObject bullet;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            GameObject spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            anim.SetTrigger("PlayerSchoot");
            canShoot = false;
            Invoke("ResetShoot", interval);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.right * dirX * speed * Time.deltaTime);
        transform.Translate(transform.up * dirY * speed * Time.deltaTime);
    }
    private void ResetShoot()
    {
        canShoot = true;
    }
}
