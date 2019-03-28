using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HalfScreenTouch : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public Camera TargetCamera;
    public MMTouchJoystick joystick;
    public Transform joystickTranform;
    Vector2 initialJoystickPosition;
    Vector2 initialDragPosition;
    bool startDrag;

    public void OnDrag(PointerEventData eventData)
    {
        if (!startDrag)
            initialDragPosition = TargetCamera.ScreenToWorldPoint(eventData.position);
        startDrag = true;

        Vector2 currentDragPosition = TargetCamera.ScreenToWorldPoint(eventData.position);
        Vector2 dragDifference = currentDragPosition - initialDragPosition;
        Vector2 updatedPosition = initialJoystickPosition + dragDifference;

        eventData.position = TargetCamera.WorldToScreenPoint(updatedPosition);
        joystick.OnDrag(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        startDrag = false;
        Vector2 dragDifference = eventData.position - initialDragPosition;
        Vector2 updatedPosition = initialJoystickPosition + dragDifference;
        eventData.position = updatedPosition;
        joystick.OnEndDrag(eventData);
    }

    // Use this for initialization
    void Start () {
        startDrag = false;
        initialJoystickPosition = joystickTranform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
