using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objective_UI : MonoBehaviour
{
    [SerializeField] private GameObject pausebutton;

    public bool activated;
    public bool show;

    public void Togglebutton()
    {
        activated = !activated;

        if (activated == true)
        {
            showobjective();
        }
        else
        {
            hideobjective();
        }
    }

    public void showobjective()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        pausebutton.SetActive(false);
        show = true;
    }

    public void hideobjective()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        pausebutton.SetActive(true);
        show = false;
    }
}
