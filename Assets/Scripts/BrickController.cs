using UnityEngine;
namespace BrickMove
{
    public class BrickController : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private FixedJoystick _joystick;
        private CharacterController _controller;
        private BrickPointMove _pointMove;

        void Start()
        {
            _controller = GetComponent<CharacterController>();
            _pointMove = GetComponent<BrickPointMove>();
        }

        void Update()
        {
            var vector = new Vector3(_joystick.Horizontal, transform.position.y,_joystick.Vertical);
            if (vector.x !=0 && vector.z !=0 && vector.y !=0)
            _pointMove.TargetPosition = transform.position;
            _controller.SimpleMove(vector * _speed);
        }
    }
}
