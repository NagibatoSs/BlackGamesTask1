using UnityEngine;
using UnityEngine.Events;

namespace BrickMove
{
    public class BrickPointMove : MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        [SerializeField] private float _speed = 3f;
        [SerializeField] public bool IsPointReached=true;
        [HideInInspector] public Vector3 TargetPosition;
        private BrickController _brickCont;
        
        private void Start() 
        {
            _controller = GetComponent<CharacterController>();
            _brickCont = GetComponent<BrickController>();
            TargetPosition = transform.position;
        }

        void Update()
        {
            if (!_brickCont.IsActive)
            {
                if (IsPointReached==false)
                {
                    var vector = TargetPosition-transform.position;
                    _controller.SimpleMove(vector.normalized*_speed);
                    SetPointReachFlag();
                }
            }
            else 
            {
                TargetPosition.x = transform.position.x;
                TargetPosition.z = transform.position.z;
            }
        }   

        private void SetPointReachFlag()
        {
            if (System.Math.Round(TargetPosition.x,2)==System.Math.Round(transform.position.x,2) 
            && System.Math.Round(TargetPosition.z,2)==System.Math.Round(transform.position.z,2))
                IsPointReached=true;
            IsPointReached=false;
        }
    }
}
