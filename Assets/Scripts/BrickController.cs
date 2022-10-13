using UnityEngine;

public class BrickController : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private FixedJoystick _joystick;
    private CharacterController _controller;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        var vector = new Vector3(_joystick.Horizontal, transform.position.y,_joystick.Vertical);
        _controller.SimpleMove(vector * _speed);
    }
}
