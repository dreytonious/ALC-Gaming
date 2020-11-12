using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Obstacle;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatDelay = 2;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void SpawnObstacle()
    {
        // Stop obstacle spawning on gameOVer
        if (playerControllerScript.gameOver == false);
        {
            Instantiate(Obstacle, spawnPos, Obstacle.transform.rotation);
        }
       
    }
}
