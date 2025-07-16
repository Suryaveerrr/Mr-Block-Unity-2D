using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    private int currentSceneIndex;
    public Level_UI levelUI;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnLevelComplete()
    {
        LoadNextLevel();
    }

    public void OnPlayerDeath()
    {
        if (levelUI != null)
        {
            levelUI.ShowGameLoseUI();
        }
        else
        {
            RestartLevel(); // fallback
        }
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting level...");
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void LoadNextLevel()
    {
        int nextSceneIndex = currentSceneIndex + 1;
        int totalNumberOfScenes = SceneManager.sceneCountInBuildSettings;

        if (nextSceneIndex < totalNumberOfScenes)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            if (levelUI != null)
            {
                levelUI.ShowGameWinUI();
            }
            else
            {
                Debug.Log("All levels complete!");
            }
        }
    }
}
