using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _targetBall;
    [SerializeField] private TargeMovement _ball;

    public Transform ReceiveBallTarget {get { return _targetBall;}}
    public TargeMovement ReceiveBall {get { return _ball;}}
}
 