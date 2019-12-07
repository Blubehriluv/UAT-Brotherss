using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float runSpeed;
    public float jumpX;
    public float jumpY;
    private float dirca;
    private Rigidbody2D rb;
    private Transform tf;
    //private float angle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirca = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(dirca * jumpX, rb.velocity.y);
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

            if (Input.GetKey(KeyCode.W) && rb.velocity.y == 0)
            {
                rb.AddForce(Vector2.up * jumpY, ForceMode2D.Impulse);
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

            if (Input.GetKey(KeyCode.W) && rb.velocity.y == 0)
            {
                rb.AddForce(Vector2.up * jumpY, ForceMode2D.Impulse);
            }
        }
    }
}