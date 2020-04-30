using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularMush : MonoBehaviour
{
    private int holder;
    public CollectibleKeep yes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            Debug.Log("Touching the shroom");
            gameObject.GetComponent<Renderer>().enabled = false;
            CollectibleKeep.regShroomCount +=1;
            yes.TriggerShroom();
            gameObject.SetActive(false);
            
        }
    }

    private void CheckStatus()
    {
        holder = CollectibleKeep.regShroomCount;
        if (holder == 3)
        {
            SpawnChecker.s3b = true;
            SpawnChecker.s2b = true;
            SpawnChecker.s1b = true;
        }
        if (holder == 2)
        {
            SpawnChecker.s2b = true;
            SpawnChecker.s1b = true;

        }
        if (holder == 1)
        {
            SpawnChecker.s1b = true;
        }
    }
}
