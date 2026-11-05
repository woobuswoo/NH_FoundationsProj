using UnityEngine;

public class PointsOnDestroy : MonoBehaviour
{
    public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
        Debug.Log("Key Item Found!");

        Destroy(this.clickObjToDestroy);

        ScoreManager.instance.AddPoint();
    }
}
