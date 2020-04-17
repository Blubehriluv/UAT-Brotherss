using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static bool began;
    public AudioSource beginMusic;
    public AudioSource winnerMusic;
    // Start is called before the first frame update
    void Start()
    {
        began = false;
        Debug.Log("wowee");

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
            PlaySound();
        }
    }

    private void PlaySound()
    {
        if (PlayerLife.soundValue == false)
        {
            winnerMusic.Play();
            
        }       

        if (PlayerLife.soundValue == true)
        {
            beginMusic.Play();
            PlayerLife.soundValue = false;
        }
    }

}
