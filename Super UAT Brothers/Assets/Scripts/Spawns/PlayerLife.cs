using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public static int playerLives;
    private SpawnChecker sc;

    // Start is called before the first frame update
    void Start()
    {
        sc = GameObject.FindGameObjectWithTag("CheckManage").GetComponent<SpawnChecker>();
        transform.position = sc.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
