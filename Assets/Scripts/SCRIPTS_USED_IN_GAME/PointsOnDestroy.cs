using UnityEngine;

public class PointsOnDestroy : MonoBehaviour
{
    public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
        Debug.Log("Key Item Found!");

        Destroy(this.clickObjToDestroy);

        //this references the scoremanager and the AddPoint method, and to update the UI by 1 point whenever an object is destroyed.

        ScoreManager.instance.AddPoint();

        SoundManager.Instance.PlayCollectSound();
        
    }
}
