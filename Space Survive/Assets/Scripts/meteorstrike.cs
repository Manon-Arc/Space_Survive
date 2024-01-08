using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorstrike : MonoBehaviour
{
    public GameObject Asteroide;
    public float spawnInterval = 0.1f;
    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-12f, 12f), 10f, 0f);
            Instantiate(Asteroide, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}