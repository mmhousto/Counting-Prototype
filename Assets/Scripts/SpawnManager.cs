using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ball;
    private Vector3 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnBall), .5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBall()
    {
        float rand = Random.Range(-13f, 13f);
        float rand2 = Random.Range(-13f, 13f);
        spawnLocation = new Vector3(rand, 15, rand2);
        GameObject clone = Instantiate(ball, spawnLocation, Quaternion.identity);
    }
}
