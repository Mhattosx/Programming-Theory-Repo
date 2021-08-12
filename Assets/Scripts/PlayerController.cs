using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedRotate = 4f;

    private PlayerAnimation _playerAnimation;

    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    void Update()
    {
        MovementHandler();
        RotateHandler();
    }

    private void MovementHandler()
    {
        var position = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (position != Vector3.zero)
        {
            _playerAnimation.Walk();
            transform.Translate(position * (speed * Time.deltaTime));
        }
        else
        {
            _playerAnimation.Hidle();
        }
    }
    private void RotateHandler()
    {
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0f, Input.GetAxis("Mouse X")* speedRotate, 0f);
        }
    }
}