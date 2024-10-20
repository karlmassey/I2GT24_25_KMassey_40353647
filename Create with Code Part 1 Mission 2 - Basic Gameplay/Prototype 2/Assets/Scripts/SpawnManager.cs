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

    private float _sideSpawnMinZ = 3f;
    private float _sideSpawnMaxZ = 15f;
    private float _sideSpawnX = 20f;


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

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-_sideSpawnX, 0, Random.Range(_sideSpawnMinZ,
        _sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(_sideSpawnX, 0, Random.Range(_sideSpawnMinZ,
        _sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
