using System.Collections;
using UnityEngine;

public class OneDirSpawnersSystem : MonoBehaviour
{
    [SerializeField] private float _spawnerCooldown;
    [SerializeField] private float _spawnDistance;

    [SerializeField] private GameObject _spawnPoint_1;
    [SerializeField] private GameObject _spawnPoint_2;
    [SerializeField] private GameObject _spawnPoint_3;

    private void Start()
    {
        StartCoroutine(SelectionCycle());
    }

    private IEnumerator SelectionCycle()
    {
        while (true)
        {
            int chosenSpawner = Random.Range(1, 4);

            SpawnerChoice(chosenSpawner);

            yield return new WaitForSeconds(_spawnerCooldown);
        }
    }

    private void SpawnerChoice(int chosenSpawner)
    {
        if (chosenSpawner == 1)
        {
            OneDirEnemySpawner _forwardEnemySpawner_1 = _spawnPoint_1.GetComponent<OneDirEnemySpawner>();
            _forwardEnemySpawner_1.Spawn(_spawnDistance);
        }

        if (chosenSpawner == 2)
        {
            OneDirEnemySpawner _forwardEnemySpawner_2 = _spawnPoint_2.GetComponent<OneDirEnemySpawner>();
            _forwardEnemySpawner_2.Spawn(_spawnDistance);
        }

        if (chosenSpawner == 3)
        {
            OneDirEnemySpawner _forwardEnemySpawner_3 = _spawnPoint_3.GetComponent<OneDirEnemySpawner>();
            _forwardEnemySpawner_3.Spawn(_spawnDistance);
        }
    }
}
