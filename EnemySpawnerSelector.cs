using System.Collections;
using UnityEngine;

public class EnemySpawnerSelector : MonoBehaviour
{
    [SerializeField] private float _spawnerCooldown;
    [SerializeField] private float _spawnDistance;

    [SerializeField] private Transform _spawnPoint_1;
    [SerializeField] private Transform _spawnPoint_2;
    [SerializeField] private Transform _spawnPoint_3;

    private WaitForSeconds _spawnerRechargeTime;

    private void Start()
    {
        _spawnerRechargeTime = new WaitForSeconds(_spawnerCooldown);

        var selectionCycle = StartCoroutine(SelectionCycle());
    }

    private IEnumerator SelectionCycle()
    {
        while (true)
        {
            int chosenSpawnerNumber = Random.Range(1, 4);

            SpawnerChoice(chosenSpawnerNumber);

            yield return _spawnerRechargeTime;
        }
    }

    private void SpawnerChoice(int chosenSpawner)
    {
        int firstSpawnPointNumber = 1;
        int secondSpawnPointNumber = 2;
        int thirdSpawnPointNumber = 3;

        if (chosenSpawner == firstSpawnPointNumber)
            SpawnLaunch(_spawnPoint_1, _spawnDistance);

        if (chosenSpawner == secondSpawnPointNumber)
            SpawnLaunch(_spawnPoint_2, _spawnDistance);

        if (chosenSpawner == thirdSpawnPointNumber)
            SpawnLaunch(_spawnPoint_3, _spawnDistance);
    }

    private void SpawnLaunch(Transform spawnPoint,float spawnDistance)
    {
        EnemySpawner spawner = spawnPoint.GetComponent<EnemySpawner>();
        spawner.Spawn(spawnDistance);
    }
}
