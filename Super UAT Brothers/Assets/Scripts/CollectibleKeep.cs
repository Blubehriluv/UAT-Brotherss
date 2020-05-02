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

    public GameObject col1;
    public GameObject col2;
    public GameObject col3;
    public GameObject col4;
    public GameObject col5;
    public GameObject col6;
    public GameObject col7;

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
        ShroomCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShroomCheck()
    {
        if (SpawnChecker.s1b == true)
        {
            col1.GetComponent<Renderer>().enabled = false;
        }
        if (SpawnChecker.s2b == true)
        {
            col2.GetComponent<Renderer>().enabled = false;
        }
        if (SpawnChecker.s3b == true)
        {
            col3.GetComponent<Renderer>().enabled = false;
        }
    }

    public void TriggerShroom()
    {
        Debug.Log("Checking and changing shrooms)");

        if (regShroomCount >= 1)
        {
            mush1.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got one");
        }
        if (regShroomCount >= 2)
        {
            mush2.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got two");
        }
        if (regShroomCount >= 3)
        {
            mush3.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got three");
        }
        if (regShroomCount >= 4)
        {
            mush4.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got four");
        }
        if (regShroomCount >= 5)
        {
            mush5.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got five");
        }
        if (regShroomCount >= 6)
        {
            mush6.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got six");
        }
        if (regShroomCount == 7)
        {
            mush7.GetComponent<Renderer>().enabled = true;
            Debug.Log("Got seven");
        }
    }
}
