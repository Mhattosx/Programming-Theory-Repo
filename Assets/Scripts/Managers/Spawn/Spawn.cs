using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefab;
    [SerializeField] private float rangeX = 20f;
    [SerializeField] private float rangeZ = 20f;
    [SerializeField] private int maxSpawn = 5;

    private GameObject lastPrefab;
    private float _time = 5f;
    private float _repeatTime = 10f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnHandler), _time, _repeatTime);
    }
    private void SpawnHandler()
    {
        if(maxSpawn == 0) return;
        lastPrefab = Instantiate(RandomAnimal(), transform.position + RandomPosition(), RandomRotate());
        lastPrefab.transform.SetParent(transform);
        maxSpawn--;

    }
    private Vector3 RandomPosition()
    {
        var posX = Random.Range(-rangeX, rangeX);
        var posZ = Random.Range(-rangeZ, rangeZ);
        
        return new Vector3(posX,0f,posZ);
    }

    private Quaternion RandomRotate()
    {
        return Quaternion.Euler(Vector3.up * Random.Range(-90f,90f));
    }
    private GameObject RandomAnimal()
    {
        var index = Random.Range(0, animalPrefab.Length);
        return animalPrefab[index];
    }
}
