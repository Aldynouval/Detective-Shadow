using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tittlescreenui : MonoBehaviour
{
    [SerializeField] GameObject settingui;
    [SerializeField] GameObject creditui;
    public void play()
    {
        SceneManager.LoadScene("level select");
    }

    public void showsetting()
    {
        settingui.SetActive(true);
    }
    public void hidesetting()
    {
        settingui.SetActive(false);
    }

    public void showcredit()
    {
        creditui.SetActive(true);
    }

    public void exit()
    {
        Application.Quit();
    }
}
