using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
namespace BrickMove
{
    public class TapPlane : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _moveObj;
        private BrickPointMove _pointMove;

        private void Start() 
        {
            _pointMove = _moveObj.GetComponent<BrickPointMove>();
        }

        public void OnPointerDown(PointerEventData data) 
        {
            _pointMove.TargetPosition = data.pointerCurrentRaycast.worldPosition;
            _pointMove.IsPointReached =false;
        }
    }
}

