using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleKeep : MonoBehaviour
{
    private static CollectibleKeep instance;
    private GameObject mush1;
    private GameObject mush2;
    private GameObject mush3;
    private GameObject mush4;
    private GameObject mush5;
    private GameObject mush6;
    private GameObject mush7;

    public GameObject Rmush1;
    public GameObject Rmush2;
    public GameObject Rmush3;

    public static int holder;

    public static int regShroomCount = 0;
    public static int rareShroomCount;

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
        mush1 = GameObject.FindGameObjectWithTag("Shroom1");
        mush2 = GameObject.FindGameObjectWithTag("Shroom2");
        mush3 = GameObject.FindGameObjectWithTag("Shroom3");
        mush4 = GameObject.FindGameObjectWithTag("Shroom4");
        mush5 = GameObject.FindGameObjectWithTag("Shroom5");
        mush6 = GameObject.FindGameObjectWithTag("Shroom6");
        mush7 = GameObject.FindGameObjectWithTag("Shroom7");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerShroom()
    {
        if (regShroomCount == 7)
        {
            mush2.SetActive(true);
            Debug.Log("Got two");
            SpawnChecker.s7b = true;
        }
        if (regShroomCount == 6)
        {
            mush2.SetActive(true);
            Debug.Log("Got two");
            SpawnChecker.s6b = true;
        }
        if (regShroomCount == 5)
        {
            mush2.SetActive(true);
            Debug.Log("Got two");
            SpawnChecker.s5b = true;
        }
        if (regShroomCount == 4)
        {
            mush2.SetActive(true);
            Debug.Log("Got two");
            SpawnChecker.s4b = true;
        }
        if (regShroomCount == 3)
        {
            mush2.SetActive(true);
            Debug.Log("Got two");
            SpawnChecker.s3b = true;
        }
        if (regShroomCount == 2)
        {
            mush2.SetActive(true);
            Debug.Log("Got two");
            SpawnChecker.s2b = true;
        }
        if (regShroomCount == 1)
        {
            mush1.SetActive(true);
            Debug.Log("Got one");
            SpawnChecker.s1b = true;
        }
    }
}
