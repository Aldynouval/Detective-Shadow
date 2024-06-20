using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_select : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            back();
        }
    }
    public void lvl1()
    {
        SceneManager.LoadScene("opening");
    }
    public void lvl2()
    {
        SceneManager.LoadScene("stage 2");
    }
    public void lvl3()
    {
        SceneManager.LoadScene("stage 3-1");
    }
    public void lvl4()
    {
        SceneManager.LoadScene("stage 4");
    }

    public void back()
    {
        SceneManager.LoadScene("Tittle screen");
    }
}
