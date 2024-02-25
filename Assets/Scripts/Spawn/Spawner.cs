using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _timeSpawn = 2f;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_timeSpawn);

        while (true)
        {
            yield return wait; 

            SpawnPoint pointToSpawn = RandomPoint();

            TargeMovement moverToTarget = Instantiate(pointToSpawn.ReceiveBall, pointToSpawn.transform.position, Quaternion.identity);
            moverToTarget.SetTarget(pointToSpawn.ReceiveBallTarget);
        }
    }

    private SpawnPoint RandomPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Count)];
    }
}