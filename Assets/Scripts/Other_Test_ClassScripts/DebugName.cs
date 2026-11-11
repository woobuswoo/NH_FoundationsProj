using UnityEngine;

public class DebugName : MonoBehaviour
{
  public void OnMouseDown()
    {
       Debug.Log("The Name of this object is " + gameObject.name); 
    }
}
