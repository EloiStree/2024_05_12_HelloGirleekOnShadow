using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GirlMono_OnPressReleaseObject3D : MonoBehaviour
{
    public bool m_isPressed = false;
    public UnityEvent m_onPress;
    public UnityEvent m_onRelease;

    private void OnMouseDown()
    {
       
        m_isPressed = true;
        m_onPress.Invoke();
    }

    private void OnMouseUp()
    {
     

        m_isPressed = false;
        m_onRelease.Invoke();
    }

    public void DisplayMessage(string message)
    {
        Debug.Log(message);

    }
}
