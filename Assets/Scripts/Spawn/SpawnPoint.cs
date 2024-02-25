using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _targetBall;
    [SerializeField] private MoveToTarget _ball;

    public Transform ReceiveBallTarget()
    {
        return _targetBall;
    }

    public MoveToTarget ReceiveBall()
    {
        return _ball;
    }
}
