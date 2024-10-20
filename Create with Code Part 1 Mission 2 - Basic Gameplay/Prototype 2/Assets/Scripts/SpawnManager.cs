using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float _spawnRangeX = 20;
    private float _spawnPosZ = 20;

    private float _startDelay = 2;
    private float _spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
    }

    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        int _animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
        Instantiate(animalPrefabs[_animalIndex], spawnPos, animalPrefabs[_animalIndex].transform.rotation);
    }
}
