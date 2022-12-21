using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public Transform ball;
    Vector3 move = Vector3.zero;
    public float speed = 3;

    void Start()
    {
        //  speed = UIManger.instance.SliderData;
        //  UIManger.instance.SavedData = speed;
    }
    void Update()
    {
        float d = ball.position.y - transform.position.y;
        if (d > 0)
        {
            move.y = speed * Mathf.Min(d, 1.0f);
        }
        if (d < 0)
        {
            move.y = -(speed * Mathf.Min(-d, 1.0f));
        }
        transform.position += move * Time.deltaTime;
    }

}

