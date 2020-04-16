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
    public static bool botControl = false;
    public static bool winner = false;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (botControl == true)
        {
            Debug.Log("bot control on");
            tf.position = tf.position + Vector3.right * speed;
        }
        else if (winner == true)
        {
            speed = 0;
            runSpeed = 0;
        }
        else if (botControl == false)
        {
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
}