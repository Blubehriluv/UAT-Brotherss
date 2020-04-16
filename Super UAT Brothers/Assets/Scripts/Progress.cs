using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    private GameObject playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Owlet_Monster");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log("Touching sign.");
            
            PlayerController.botControl = true;
            MovementAnim.animControl = true;
        }
    }
}
