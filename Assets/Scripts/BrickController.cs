using UnityEngine;
namespace BrickMove
{
    public class BrickController : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private FixedJoystick _joystick;
        private CharacterController _controller;
        [HideInInspector] public bool IsActive=false;

        void Start()
        {
            _controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            var vector = new Vector3(_joystick.Horizontal, transform.position.y,_joystick.Vertical);
            if (vector.x !=0 || vector.z !=0)
                IsActive = true;
            else 
                IsActive = false;
            _controller.SimpleMove(vector * _speed);
        }
    }
}
