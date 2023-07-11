using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives;
    public bool isGameOver = false;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;
    public TextMeshProUGUI highScoreText;
    private PlayerRotater playerRotater;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;
        playerRotater = FindObjectOfType<PlayerRotater>();
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        IncreaseRotationSpeed();
        SetHighScore(score);
    }

    public void UpdateLive()
    {
        if (lives != 0)
        {
            lives--;
            liveText.text = lives.ToString();
        }

        if (lives == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    void IncreaseRotationSpeed()
    {
        if (score % 10 == 0)
        {
            playerRotater.rotateSpeed += Random.Range(1, 6); ;
        }
    }

    void SetHighScore(int score)
    {
        if (score > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
