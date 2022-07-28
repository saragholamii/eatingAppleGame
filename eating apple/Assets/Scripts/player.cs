using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField, Range(0.1f, 5f)]
    float speed = 0.5f;
    [SerializeField, Range(2f, 10f)]
    float jumpPower = 2;
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spRenderer;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        transform.Translate(xInput * speed * Time.deltaTime, yInput * speed * Time.deltaTime * jumpPower, 0f);
        DoAnimation(xInput, yInput);
    }

    public void DoAnimation(float xInput, float yInput){

        if(xInput < 0f){
            animator.SetBool("isWalking", true);
            spRenderer.flipX = false;
        }

        else if(xInput > 0f){
            animator.SetBool("isWalking", true);
            spRenderer.flipX = true;
        }

        else{
            animator.SetBool("isWalking", false);
        }

        
    }
}
