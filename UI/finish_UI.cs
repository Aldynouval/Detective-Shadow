using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish_UI : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private player_shorcut shortcut;
    int nextsceneload;

    private void OnEnable()
    {
        button.SetActive(false);
        Time.timeScale = 0f;
        shortcut.enabled = false;
        nextsceneload = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void continuelevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(nextsceneload);
    }
    public void tittlescreen()
    {
        SceneManager.LoadScene("Tittle screen");
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void restart_stage3()
    {
        SceneManager.LoadScene("stage 3-1");
        Time.timeScale = 1f;
    }
}
