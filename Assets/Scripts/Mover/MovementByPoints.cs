using UnityEngine;

[RequireComponent(typeof(TargeMovement))]
public class MovementByPoints : MonoBehaviour
{
    [SerializeField] private Transform _pathPoints;

    private Transform[] _points;
    private int _currentPoint;

    private TargeMovement _moverToTarget;
    private Transform _target;

    private void Start()
    {
        _moverToTarget = GetComponent<TargeMovement>();

        SetPoints();

        _target = _points[_currentPoint];
        _moverToTarget.SetTarget(_target);
    }

    private void Update()
    {
        if (transform.position != _target.position)
            return;

        SetNextTarget();
    }

    private void SetPoints()
    {
        _points = new Transform[_pathPoints.childCount];

        for (int i = 0; i < _pathPoints.childCount; i++)
            _points[i] = _pathPoints.GetChild(i);
    }

    private void SetNextTarget()
    {
        _currentPoint++;

        if (_currentPoint >= _points.Length)
            _currentPoint = 0;

        _target = _points[_currentPoint];

        _moverToTarget.SetTarget(_target);
    }
}
