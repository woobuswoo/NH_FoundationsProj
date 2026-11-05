using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;

public class ScoreManager : MonoBehaviour
{
    // USED COCO CODE ON YOUTUBES TUTORIAL 
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText; // reference to the ui text component

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
    
    
    
}
