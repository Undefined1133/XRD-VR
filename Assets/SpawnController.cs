using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject objectToSpawn; // The object prefab to instantiate
    public Transform[] spawnPoints;   // Array of spawn points

    private float spawnInterval;
    private Coroutine spawnCoroutine;
    private PointSystemSingleton pointsSystemSingleton;

    private void Start()
    {
        pointsSystemSingleton = PointSystemSingleton.instance;
        SetSpawnInterval(2f);
    }

    public void SetSpawnInterval(float interval)
    {
        pointsSystemSingleton.ResetPoints();
        spawnInterval = interval;

        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
        }
        spawnCoroutine = StartCoroutine(SpawnObjectsForDuration(20f));
    }

    public void StopSpawn()
    {
        pointsSystemSingleton.ResetPoints();
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
            GameObject[] shootables = GameObject.FindGameObjectsWithTag("Shootable");

            foreach (GameObject shootable in shootables)
            {
                Destroy(shootable);
            }
        }
    }

    IEnumerator SpawnObjectsForDuration(float duration)
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(objectToSpawn, randomSpawnPoint.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
            elapsedTime += spawnInterval;
        }
    }
}
