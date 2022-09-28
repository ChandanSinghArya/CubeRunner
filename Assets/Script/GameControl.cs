using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject taptostarttext;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(false);
        GamePause();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void GamePause()
    {
        Time.timeScale = 0f;
        taptostarttext.SetActive(true);
        scoreText.SetActive(false);
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        taptostarttext.SetActive(false);
        scoreText.SetActive(true);
    }
    
}
