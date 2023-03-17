using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float spawnPosX = 33f;
    private float spawnRangeZ = 15f;

    private float spawnDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPosUp = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));

        Instantiate(animalPrefab[animalIndex], spawnPosUp, animalPrefab[animalIndex].transform.rotation);
        Instantiate(animalPrefab[animalIndex], spawnPosRight, Quaternion.Euler(0f, 270f, 0f));
        Instantiate(animalPrefab[animalIndex], spawnPosLeft, Quaternion.Euler(0f, 90f, 0f));
    }
}
