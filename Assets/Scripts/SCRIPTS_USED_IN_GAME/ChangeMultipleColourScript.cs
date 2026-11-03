using UnityEngine;

public class ChangeMultipleColourScript : MonoBehaviour
{
    Renderer m_Renderer;
    Color[] m_OriginalColors; // used an array to keep original colours of multiple materials

    public Material[] materials; // public array (multiple materials) to be assigned

    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        
        m_OriginalColors = new Color[materials.Length];  // ensures the array is the same length (amount) as the number of materials

        for (int i = 0; i < materials.Length; i++) //
        {
            m_OriginalColors[i] = materials[i].color;
        }
    }

    void OnMouseOver()
    {
      Material[] materials = m_Renderer.materials;
      if (materials.Length > 0)
        {
            materials[0].color = Color.softYellow;
        }

        if (materials.Length > 1)
        {
            materials[1].color = Color.softYellow;
        }
    }

    void OnMouseExit()
    {
        Material[] materials = m_Renderer.materials;
       if (materials.Length > 0)
        {
            materials[0].color = m_OriginalColors[0];
        }

        if (materials.Length > 1)
        {
            materials[1].color = m_OriginalColors[1];
        }
    }
}
