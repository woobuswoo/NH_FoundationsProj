using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //USED YOUTUBE TUTORIAL BY BIG KYLE
   public GameObject pauseMenu;
   public GameObject helpMenu;
   public GameObject aboutMenu;
   public GameObject objectiveMenu;

   private bool isPaused = false; 

   private void Update()
    {
        //this is to basically hit escape to pause and unpause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PausedGame();
            }
        }
    }

   public void ResumeGame()
    {
        //this tells the game to unpause, saying that none of the menus are true/active. also tells the game to hide the cursor again and lock the camera back to cursor.

        pauseMenu.SetActive(false);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(false);

        Time.timeScale = 1;

        isPaused = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void PausedGame()
    {
        //this says that if escape has been pressed, that the game is paused and to bring up the pause menu/ui. it also allows the cursor to reappear and to pause the game world too.
        pauseMenu.SetActive(true);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(false);

        Time.timeScale = 0;
        isPaused = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    

    public void OpenHelp()
    {
        //this says that once the button is clicked to hide the pause menu and open the help menu.
        pauseMenu.SetActive(false);
        helpMenu.SetActive(true);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(false);

    }

    public void CloseHelp()
    {
        //this says to hide the help menu and open the pause menu when the go back button is pressed, hence the use of the bool(true/false)
        pauseMenu.SetActive(true);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(false);
    }

    public void QuitGame()
    {
        //to quite the game once the quit button is pressed.
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void OpenAbout()
    {
        //same as the help button but with the about button.
        pauseMenu.SetActive(false);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(true);
        objectiveMenu.SetActive(false);
    }

    public void CloseAbout()
    {
        pauseMenu.SetActive(true);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(false);
    }

    public void OpenObjective()
    {
        pauseMenu.SetActive(false);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(true);

    }

    public void CloseObjective()
    {
        pauseMenu.SetActive(true);
        helpMenu.SetActive(false);
        aboutMenu.SetActive(false);
        objectiveMenu.SetActive(false);
    }
}
