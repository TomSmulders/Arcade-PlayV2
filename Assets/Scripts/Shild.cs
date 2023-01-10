using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shild : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("SoundEffects").GetComponent<AudioSource>();

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
            audioSource.Play();
            collision.enabled = false;
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
            PlayerHealth col = collision.gameObject.GetComponent<PlayerHealth>();
            col.StartCoroutine(col.turnOffShild());
            Destroy(gameObject);
        }
    }


}
