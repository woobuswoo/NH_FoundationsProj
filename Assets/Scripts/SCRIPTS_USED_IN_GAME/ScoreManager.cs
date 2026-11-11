using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // USED COCO CODE ON YOUTUBES TUTORIAL 
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText; // reference to the ui text component
    public int endGame = 4; //the end game score to activate the gamewin menu
    public GameObject gameWinMenu; //reference to the gamewin menu ui

    int score = 0; // keep track of current score
    

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " / 4"; // restart counter
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " / 4";
    }

    void Update()
    {
        // this says that when the score reaches the endGame score (4) to bring up the gamewin menu screen.
        if (score>= endGame)
        {
            GameWin();
        }
    }

    private void GameWin()
    {
        gameWinMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RestartLevel()
    {
        gameWinMenu.SetActive(false);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //this allows us to restart the game within the gamewin menu

    }

     public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
