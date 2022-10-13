using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapMove : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private GameObject _moveObj;

    public void OnPointerUp(PointerEventData data) 
    {
        Debug.Log("up");
        var resPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("kuda"+resPosition);
        Debug.Log("current"+_moveObj.transform.position);
        _moveObj.transform.position = Vector3.MoveTowards(_moveObj.transform.position,resPosition,3f*Time.deltaTime);
        Debug.Log(_moveObj.name);
        Debug.Log(_moveObj.transform.position);
    }

    public void OnPointerDown(PointerEventData data) 
    {
        
    }
}

