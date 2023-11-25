using UnityEngine;

public class EnemyMovingToTarget : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private Transform _target;
    private void Start()
    {
        EnemySpawner _enemySpawner = GetComponentInParent<EnemySpawner>();
        if (_enemySpawner != null)
            _target = _enemySpawner.GetSpawnerTarget();
    }
    private void Update()
    {
        MovingToTarget();
    }
    private void MovingToTarget()
    {
        if(_target != null && transform.position != _target.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, _movingSpeed * Time.deltaTime);
        }
    }
}
