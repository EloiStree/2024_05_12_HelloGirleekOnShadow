using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GirlMono_OnPressReleasePanel2D : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool m_isPress;
    public UnityEvent m_onPress;
    public UnityEvent m_onRelease;

    public void OnPointerDown(PointerEventData eventData)
    {
        m_isPress = true;
        m_onPress.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        m_isPress = false;
        m_onRelease.Invoke();
    }


    
}
