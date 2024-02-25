using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private int _speed = 5;
    
    private Transform _target;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
