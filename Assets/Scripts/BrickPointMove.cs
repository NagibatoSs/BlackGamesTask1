using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace BrickMove
{
    public class BrickPointMove : MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        [SerializeField] private float _speed = 0.5f;
        //private Vector3 _targetPosition;
        public Vector3 TargetPosition { get; set; }

        private void Start() {
             _controller = GetComponent<CharacterController>();
             TargetPosition = transform.position;
        }

        void Update()
        {
            var vector = TargetPosition-transform.position;
            _controller.SimpleMove(vector*_speed); 
            // transform.position=Vector3.MoveTowards(transform.position,TargetPosition,_speed);
        }   
    }
}
