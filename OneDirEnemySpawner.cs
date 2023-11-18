using UnityEngine;
using DG.Tweening;

public class OneDirEnemySpawner : MonoBehaviour
{
    [SerializeField] private int _moveDirection;

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _enemyTemplate;

    private GameObject _spawnedEnemy;

    public void Spawn(float spawnDistance, float mowingDuration = 0)
    {
        _spawnedEnemy = Instantiate(_enemyTemplate, new Vector3(0, 0, 0), Quaternion.identity, _spawnPoint);

        _spawnedEnemy.transform.DOLocalMoveX(spawnDistance, mowingDuration, false);
        _spawnedEnemy.transform.DOLocalMoveY(spawnDistance, mowingDuration, false);
    }

    public int GetMoveDirection() {return _moveDirection;}
}
