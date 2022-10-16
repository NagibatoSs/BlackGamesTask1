using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
namespace BrickMove
{
    public class TapPlane : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
    {
        [SerializeField] private GameObject _moveObj;
        private CharacterController _controller;
        private BrickPointMove _pointMove;

        private void Start() {
            _controller = _moveObj.GetComponent<CharacterController>();
            _pointMove = _moveObj.GetComponent<BrickPointMove>();
        }

        public void OnPointerUp(PointerEventData data) 
        {
            Debug.Log("up");
            var vector = data.pointerCurrentRaycast.worldPosition;
            Debug.Log(vector);
            _pointMove.TargetPosition = vector;
        }
        public void OnPointerDown(PointerEventData data) 
        {
            // Debug.Log("down");
            // _pointMove.TargetPosition = data.pointerCurrentRaycast.worldPosition;
        }
    }
}

