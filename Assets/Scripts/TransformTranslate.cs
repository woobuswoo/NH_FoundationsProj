using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0,0,1);
            Debug.Log("S Key was pressed");
        }

         if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0,0,-1);
            Debug.Log("W Key was pressed");
        }

         if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1,0,0);
            Debug.Log("A Key was pressed");
        }

         if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1,0,0);
            Debug.Log("D Key was pressed");
        }
         if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0,1,0);
            Debug.Log("Space Key was pressed");
        }

          if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Translate(0,-1,0);
            Debug.Log("Z Key was pressed");
        }

    }

}
