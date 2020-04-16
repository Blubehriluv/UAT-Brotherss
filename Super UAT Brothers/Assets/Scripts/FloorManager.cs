using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    public static bool isGrounded;
    public static int jumps;
    // Start is called before the first frame update
    void Start()
    {
        jumps = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.FindGameObjectWithTag("Feet"))
        {
            Debug.Log("Player is grounded.");
            jumps = 2;
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (GameObject.FindGameObjectWithTag("Feet"))
        {
            isGrounded = false;
            Debug.Log("Player is jumping.");
        }
    }
}
