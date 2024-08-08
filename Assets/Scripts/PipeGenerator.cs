using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : ObjectPool
{

    [SerializeField] private GameObject _tempate;
    [SerializeField] private float _secondBetwenSpawn;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private float _elapsedTime = 0; // Время которое прошло

    private void Start()
    {
        Initialized(_tempate);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _secondBetwenSpawn)
        {
            if(TryGetObject(out GameObject pipe))
            {
                _elapsedTime = 0;

                float spawnPositionY = Random.Range(_minSpawnPositionY, _maxSpawnPositionY);
                Vector3 spawnPoint = new Vector3(transform.position.x, spawnPositionY, transform.position.z); // Спавним префаб по новой
                pipe.SetActive(true);
                pipe.transform.position = spawnPoint;

                DisableObjectAbroadScreen(); 
            }
        }
    }

}
