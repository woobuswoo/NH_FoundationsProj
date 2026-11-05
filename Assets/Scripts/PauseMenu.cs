using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject CONTAINER;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CONTAINER.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeBttn()
    {
        CONTAINER.SetActive(true);
         Time.timeScale = 1;
    }

    public void Quitbttn()
    {
        Application.Quit();
    }

}
