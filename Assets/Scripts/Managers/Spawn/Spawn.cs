using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject foxPrefab;
    [SerializeField] private float range = 20f;
    [SerializeField] private int maxSpawn = 5;

    private float _time = 5f;
    private float _repeatTime = 10f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnHandler), _time, _repeatTime);
    }
    private void SpawnHandler()
    {
        if(maxSpawn == 0) return;
        var fox = Instantiate(foxPrefab, transform.position + RandomPosition(), foxPrefab.transform.rotation);
        fox.transform.SetParent(transform);
        maxSpawn--;

    }
    private Vector3 RandomPosition()
    {
        var posX = Random.Range(-range, range);
        var posZ = Random.Range(-range, range);
        
        return new Vector3(posX,0f,posZ);
    }
}
