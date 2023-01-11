using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class pickupoHeart : MonoBehaviour
{

    // Start is called before the first frame update
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("SoundEffectPickUp").GetComponent<AudioSource>();

        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            PlayerHealth col = collision.gameObject.GetComponent<PlayerHealth>();
            col.addHealth(1);
            Destroy(gameObject);
        }
    }

    
}