using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnim : MonoBehaviour
{
    bool facingRight = true;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimationState();
    }

    void SetAnimationState()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (facingRight == false)
            {
                Flip();
            }
            anim.SetBool("isWalking", true);
            Debug.Log("Right Walking is happening");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isWalking", false);
            Debug.Log("RIGHT STOP WALK");
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("isRunning", true);
            Debug.Log("Right running.");
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (facingRight == true)
            {
                Flip();
            }
            anim.SetBool("isWalking", true);
            Debug.Log("Left Walking is happening");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("isWalking", false);
            Debug.Log("LEFT STOP WALK");
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("isRunning", true);
            Debug.Log("Left Running is happening");
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("isRunning", false);
        }


        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isJumping", false);
        }

        
    }

    void Flip()
    {
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}