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
    public int endGame = 4;
    public GameObject gameWinMenu;

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


    }

     public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
