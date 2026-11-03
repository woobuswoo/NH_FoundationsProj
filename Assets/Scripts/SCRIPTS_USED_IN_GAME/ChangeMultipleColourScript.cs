using UnityEngine;

public class ChangeMultipleColourScript : MonoBehaviour
{
    Renderer m_Renderer;
    Color[] m_OriginalColors;
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();

        
        Material[] materials = m_Renderer.materials;
        
       
        m_OriginalColors = new Color[materials.Length];

        for (int i = 0; i < materials.Length; i++)
        {
            m_OriginalColors[i] = materials[i].color;
        }
    }

    void OnMouseOver()
    {
      Material[] materials = m_Renderer.materials;
      for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = Color.softYellow;
        }
    }

    void OnMouseExit()
    {
        Material[] materials = m_Renderer.materials;
        for (int i=0; i <materials.Length; i++)
        {
            materials[i].color = m_OriginalColors[i];
        }
    }
}
