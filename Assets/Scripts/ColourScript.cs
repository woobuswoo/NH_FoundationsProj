using UnityEngine;

public class ColourScript : MonoBehaviour
{
    Renderer m_Renderer;
    void Start()
    {
       m_Renderer = GetComponent<Renderer>();
    }

//Run your mouse over the GameObject to change the Renderer's material color to blue
    void OnMouseOver()
    {
      m_Renderer.material.color = Color.blue;
    }
//Change the Material's color back to white when the mouse exists the GameObject
    void OnMouseExit()
    {
        m_Renderer.material.color = Color.white;
    }
}
