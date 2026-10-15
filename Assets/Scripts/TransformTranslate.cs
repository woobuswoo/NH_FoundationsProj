using UnityEngine;
using UnityEngine.UIElements;

public class TransformTranslate : MonoBehaviour
{
    public float movementSpeed;

    public float rotationSpeed;

    void Update()
    {
         /*if (Input.GetKeyDown(KeyCode.S))
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
        }*/
        
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * movementSpeed * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.up * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(-transform.up * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate((-1) * transform.up * movementSpeed * Time.deltaTime);
        }


    }

}
