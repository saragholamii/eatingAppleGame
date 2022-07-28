using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : MonoBehaviour
{
    [SerializeField]
    float switchTime, speed;

    float timeCounter = 0;

    SpriteRenderer sp;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);
        timeCounter += Time.deltaTime;

        if(timeCounter >= switchTime){

            if(speed < 0)
                sp.flipX = false;
            else if (speed > 0)
                sp.flipX = true;

            speed *= -1;
            timeCounter = 0;
        }
    }
}
