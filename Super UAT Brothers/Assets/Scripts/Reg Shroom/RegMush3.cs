﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegMush3 : MonoBehaviour
{
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
            CollectibleKeep.regShroomCount += 1;
            yes.TriggerShroom();
            SpawnChecker.s3b = true;
            gameObject.SetActive(false);

        }
    }
}
