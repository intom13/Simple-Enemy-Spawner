using UnityEngine;
using DG.Tweening;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _moveDirection;

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _enemyTemplate;

    private GameObject _spawnedEnemy;

    public void Spawn(float spawnDistanceY, float spawnDistanceX = 0, float mowingDuration = 0)
    {
        _spawnedEnemy = Instantiate(_enemyTemplate, new Vector3(0, 0, 0), Quaternion.identity, _spawnPoint);

        _spawnedEnemy.transform.DOLocalMoveX(spawnDistanceX, mowingDuration, false);
        _spawnedEnemy.transform.DOLocalMoveY(spawnDistanceY, mowingDuration, false);
    }

    public int GetMoveDirection() {return _moveDirection;}
}
