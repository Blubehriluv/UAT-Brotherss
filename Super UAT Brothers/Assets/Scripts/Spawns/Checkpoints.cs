using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private SpawnChecker SC;


    // Start is called before the first frame update
    void Start()
    {
        SC = GameObject.FindGameObjectWithTag("CheckManage").GetComponent<SpawnChecker>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            SC.lastCheckPointPos = transform.position;
        }
    }
}
