using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Tank : MonoBehaviour
{
    protected const float TurnAngle = 90;

    [Header("Parameters")]
    [SerializeField] private float _moveSpeed;

    private Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    protected void MoveForward()
    {
        Move(transform.up);
    }
    protected void MoveBackward()
    {
        Move(-transform.up);
    }
    protected void Move(Vector2 direction)
    {
        _rigidbody.velocity = _moveSpeed * direction;
    }

    protected void TurnLeft()
    {
        Turn(-TurnAngle);
    }
    protected void TurnRight()
    {
        Turn(TurnAngle);
    }
    private void Turn(float angle)
    {
        transform.Rotate(0, 0, angle);
    }

    protected void Fire()
    {
        throw new System.NotImplementedException();
    }
}