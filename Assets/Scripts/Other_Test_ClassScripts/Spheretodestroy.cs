using UnityEngine;

public class Spheretodestroy : MonoBehaviour
{
    void Start()
    {
        Debug.Log("start2");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable2");
    
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy2");
    }
}
