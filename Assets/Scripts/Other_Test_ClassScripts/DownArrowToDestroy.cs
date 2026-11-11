using UnityEngine;

public class DownArrowToDestroy : MonoBehaviour
{
  public GameObject gameObjectToDestroy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Destroy(gameObjectToDestroy);
        }
    }

    void OnDestroy()
    {
        Debug.Log("Sphere destroyed");
    }
}
