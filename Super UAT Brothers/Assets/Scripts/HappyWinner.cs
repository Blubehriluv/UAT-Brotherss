using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyWinner : MonoBehaviour
{
    private GameObject player;
    public Canvas myCanvas;
    private PlayerController PC;

    // Start is called before the first frame update
    void Start()
    {
        myCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            PlayerController.botControl = false;
            MovementAnim.animControl = false;
            PlayerController.winner = true;
            myCanvas.enabled = true;    
        }
    }

    public void ResumeControl()
    {
        PlayerController.winner = false;
    }


}
