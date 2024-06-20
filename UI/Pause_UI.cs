using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_UI : MonoBehaviour
{
    public bool pause;
    [SerializeField] private GameObject setting_ui;

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    public void PauseGame()
    {
        gameObject.SetActive(true);
        pause = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        gameObject.SetActive(false);
        pause = false;
        Time.timeScale = 1f;
    }

    public void settings()
    {
        setting_ui.SetActive(true);
    }

    public void TittleScreen()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tittle screen");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
