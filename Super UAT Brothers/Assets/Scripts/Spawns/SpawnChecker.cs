using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChecker : MonoBehaviour
{
    private static SpawnChecker instance;
    public Vector2 lastCheckPointPos;
    public AudioSource music;
    public static bool s1b;
    public static bool s2b;
    public static bool s3b;
    public static bool s4b;
    public static bool s5b;
    public static bool s6b;
    public static bool s7b;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        FreshSetCollect();
        music = GetComponent<AudioSource>();
        PlayMoosic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FreshSetCollect()
    {
        s1b = false;
        s2b = false;
        s3b = false;
        s4b = false;
        s5b = false;
        s6b = false;
        s7b = false;
    }

    public void PlayMoosic()
    {
        music.Play();
    }

    public void StopMusic()
    {
        music.Stop();
    }
}
