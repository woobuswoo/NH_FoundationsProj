using UnityEngine;

public class ColourScript : MonoBehaviour
{
    Renderer m_Renderer;
    Color m_OriginalColor;
    void Start()
    {
       m_Renderer = GetComponent<Renderer>();

       m_OriginalColor = m_Renderer.material.color;
    }

//Run your mouse over the GameObject to change the Renderer's material colour to blue
    void OnMouseOver()
    {
      m_Renderer.material.color = Color.softYellow;
    }
//Change the Material's color back to its original colour
    void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }
}
