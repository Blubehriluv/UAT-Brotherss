using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform tf;
    public float speed;
    public Transform FollowObject;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.D))
        {
            tf.position = tf.position + Vector3.right * speed;
        }    
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = tf.position + Vector3.left * speed;
        }*/

        Vector3 pos = new Vector3(FollowObject.position.x, 0, transform.position.z);
        transform.position = pos;
    }

    
}
