using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleKeep : MonoBehaviour
{
    private static CollectibleKeep instance;
    public GameObject mush1;
    public GameObject mush2;
    public GameObject mush3;
    public GameObject mush4;
    public GameObject mush5;
    public GameObject mush6;
    public GameObject mush7;

    public GameObject Rmush1;
    public GameObject Rmush2;
    public GameObject Rmush3;

    public static int holder;

    public static int regShroomCount = 0;
    public static int rareShroomCount;

    // Start is called before the first frame update
    void Start()
    {
        regShroomCount = SpawnChecker.holder;
        
        TriggerShroom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShroomCheck()
    {
        if (regShroomCount != 0)
        {
            if (regShroomCount == 1)
            {
                SpawnChecker.s1b = true;
            }
            if (regShroomCount == 2)
            {
                SpawnChecker.s2b = true;
            }
        }
    }

    public void TriggerShroom()
    {
        Debug.Log("Checking and changing shrooms)");
        if (regShroomCount == 7)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got seven");
        }
        if (regShroomCount == 6)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got six");
        }
        if (regShroomCount == 5)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got five");
        }
        if (regShroomCount == 4)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got four");
        }
        if (regShroomCount == 3)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got three");
        }
        if (regShroomCount == 2)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got two");
        }
        if (regShroomCount == 1)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got one");
        }
    }
}
