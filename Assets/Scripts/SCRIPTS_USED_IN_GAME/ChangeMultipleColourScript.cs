using UnityEngine;

public class ChangeMultipleColourScript : MonoBehaviour
{
    Renderer m_Renderer;
    Color[] m_OriginalColors; //Array to store original colours of material
    void Start()
    {
       m_Renderer = GetComponent<Renderer>();

       Material[] materials = m_Renderer.materials; //Array of all the original materials from renderer

       m_OriginalColors = new Color[materials.Length]; //ensure the Color array is the same amount as the materials array
       for (int i = 0; i < materials.Length; i++)
        {
            m_OriginalColors[i] = materials[i].color; //this is saying, take the original colour of the material and store it in the same array slot as material.color, ensuring we can use the original colours again.
        }
    }
 
    void OnMouseOver()
    {
      Material[] materials = m_Renderer.materials; //taking the original materials from renderer
      for (int i = 0; i < materials.Length; i++) //this for loop is basically saying, create an iteration of the m_renderer materials, change the colour of those materials to yellow. 
        {
            materials[i].color = Color.softYellow;
        }
    }
//Change the Material's color back to its original colour
    void OnMouseExit()
    {
       Material[] materials = m_Renderer.materials; //this for loop is basically saying, create an iteration of the m_renderer materials and for each material in that array change it back to the original colour, which is in the m_OriginalColors.
       for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = m_OriginalColors[i];
        }
    }
}
