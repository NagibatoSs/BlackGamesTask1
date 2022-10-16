using UnityEngine;
using UnityEngine.Events;

namespace BrickMove
{
    public class BrickPointMove : MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        [SerializeField] private float _speed = 3f;
        public Vector3 TargetPosition { get; set; }
        private BrickController _brickCont;

        private void Start() {
             _controller = GetComponent<CharacterController>();
             _brickCont = GetComponent<BrickController>();
             TargetPosition = transform.position;
        }

        void Update()
        {
            if (!_brickCont.IsActive)
            {
                var vector = TargetPosition-transform.position;
                _controller.SimpleMove(vector.normalized*_speed); 
            }
            else 
                TargetPosition = transform.position;
        }   
    }
}
