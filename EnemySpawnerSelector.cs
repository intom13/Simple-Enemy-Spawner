using System.Collections;
using UnityEngine;

public class EnemySpawnerSelector : MonoBehaviour
{
    [SerializeField] private float _spawnerCooldown;
    [SerializeField] private float _spawnDistance;

    [SerializeField] private Transform _spawnPoint_2;
    [SerializeField] private Transform _spawnPoint_3;
    [SerializeField] private Transform _spawnPoint_1;

    private WaitForSeconds _spawnerRechargeTime;

    private void Start()
    {
        Transform[] _spawnPoints =
        {
            _spawnPoint_1,
            _spawnPoint_2,
            _spawnPoint_3,
        };

        _spawnerRechargeTime = new WaitForSeconds(_spawnerCooldown);

        var selectionCycle = StartCoroutine(SelectionCycle(_spawnPoints));
    }

    private IEnumerator SelectionCycle(Transform[] spawnPoints)
    {
        while (true)
        {
            int chosenSpawnerNumber = Random.Range(0, 3);

            SpawnLaunch(spawnPoints[chosenSpawnerNumber], _spawnDistance);

            yield return _spawnerRechargeTime;
        }
    }

    private void SpawnLaunch(Transform spawnPoint,float spawnDistance)
    {
        EnemySpawner spawner = spawnPoint.GetComponent<EnemySpawner>();
        spawner.Spawn(spawnDistance);
    }
}
