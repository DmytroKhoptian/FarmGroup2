using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sheepPrefab; //префаб овцы
    [SerializeField] private Vector3 spawnPosition; //позиция спауна
    [SerializeField] private Vector2 xSpawnBounds; // границы позиции спауна (будет выбрана рандомная точка в этом диапазоне)

    [SerializeField] private int sheepCount;
    [SerializeField] private float spawnRate; //частота появления между овцами
    [SerializeField] private float waveRate; //частота между волнами
    [SerializeField] private int sheepCountWaveIncrease;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            for (int i = 0; i < sheepCount; i++)
            {
                CreateSheep(); //Spawn
                yield return new WaitForSeconds(spawnRate);
            }
            sheepCount *= sheepCountWaveIncrease; //sheepCount = sheepCount * sheepCountWaveIncrease; 
            yield return new WaitForSeconds(waveRate);
        }
    }
    private void CreateSheep()
    {
        float xRandomPosition = Random.Range(xSpawnBounds.x, xSpawnBounds.y); // найти рандомную позицию по икс
        Vector3 randomSpawnPosition = new Vector3(xRandomPosition, spawnPosition.y, spawnPosition.z); // сформировать новую позицию
        Instantiate(sheepPrefab, randomSpawnPosition, sheepPrefab.transform.rotation);  


    }

    
}
