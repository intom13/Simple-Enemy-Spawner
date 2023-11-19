using UnityEngine;

public class OneDirEnemyMoving : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private int _moveDirection;

    private void Start()
    {
        EnemySpawner _forwardEnemySpawner = GetComponentInParent<EnemySpawner>();

        _moveDirection = _forwardEnemySpawner.GetMoveDirection();
    }

    private void Update()
    {
        Move(_moveDirection);
    }

    public void Move(int direction)
    {
        transform.Translate(_movingSpeed * direction, 0, 0);
    }
}
