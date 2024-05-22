using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClickMono : MonoBehaviour
{
 
    public Color m_color;
    public MeshRenderer m_target;

    void Start()
    {
        m_target.material.color = m_color;
    }

    void Update()
    {
        SetRandomColor();
    }

    [ContextMenu("Set Default Color")]
    public void SetDefaultColor() {

        m_target.material.color = m_color;
    }

    [ContextMenu("Set Random Color")]
    public void SetRandomColor() {
        m_target.material.color = new Color(
               Random.Range(0f, 1f), Random.Range(0f, 1f),
               Random.Range(0f, 1f), 1);
    }
}
