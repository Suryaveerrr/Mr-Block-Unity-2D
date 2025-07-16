using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level_UI : MonoBehaviour
{
    public GameObject LevelPanel;
    public TextMeshProUGUI LevelText;
    public int LevelNumber = 1;

    public GameObject gameOverPanel;
    public Button restartButton;

    public TextMeshProUGUI gameOverText;
    

    void Start()
    {
        UpdateLevel();
        gameOverPanel.SetActive(false); // Hide GameOver at start
    }

    private void UpdateLevel()
    {
        LevelText.text = "Level: " + LevelNumber;
    }

    private void HideLevelPanel()
    {
        LevelPanel.SetActive(false);
    }

    private void SetGameOverPanel(bool isActive)
    {
        gameOverPanel.SetActive(isActive);
    }

    public void ShowGameWinUI()
    {
        SetGameOverPanel(true);
        gameOverText.text = "Game Completed!!";
        gameOverText.color = Color.green;
        HideLevelPanel();
    }

    public void ShowGameLoseUI()
    {
        SetGameOverPanel(true);
        gameOverText.text = "Game Over!!";
        
        HideLevelPanel();
    }
}