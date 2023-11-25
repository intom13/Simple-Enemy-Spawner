using UnityEngine;
using DG.Tweening;

public class SpawnerTarget : MonoBehaviour
{
    [SerializeField] private float _xMovingValue;
    [SerializeField] private float _yMovingValue;

    [SerializeField] private float _movingDuration;

    private Transform _transform;
    private Vector3 _endValue;

    private void Start()
    {
        _transform = GetComponent<Transform>();

        _endValue = _transform.position;
        _endValue = new Vector3(_xMovingValue, _yMovingValue);

        transform.DOLocalMove(transform.position + _endValue, _movingDuration).SetLoops(-1,LoopType.Yoyo);
    }
}
