using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float runSpeed;
    public float jumpSpeed;
    private Rigidbody2D rb;
    private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(dirca * jumpX, rb.velocity.y);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.A))
            {
                tf.position = tf.position + Vector3.left * runSpeed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                tf.position = tf.position + Vector3.right * runSpeed;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (FloorManager.jumps != 0)
                {
                    rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);
                    FloorManager.jumps -= 1;
                }
            }
        }

        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                tf.position = tf.position + Vector3.left * speed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                tf.position = tf.position + Vector3.right * speed;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (FloorManager.jumps != 0)
                {
                    rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);
                    FloorManager.jumps -= 1;
                }
            }
        }
    }
}