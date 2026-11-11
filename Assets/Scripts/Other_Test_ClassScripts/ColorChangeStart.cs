using UnityEngine;

public class ColorChangeStart : MonoBehaviour
{
    Renderer m_Renderer;
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.color = Color.red;
    }


}
