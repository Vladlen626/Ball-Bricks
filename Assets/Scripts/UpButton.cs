using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{
    public void OnPointerDown(PointerEventData eventData) {
        Ball.clicked = true;
    }


    public void OnPointerUp(PointerEventData eventData) {
        Ball.clicked = false;
    }
}
