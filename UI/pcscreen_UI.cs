using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcscreen_UI : MonoBehaviour
{
    [SerializeField] private player_shorcut button;
    [SerializeField] private camera zoom;

    private void OnEnable()
    {
        button.enabled = false;
        Time.timeScale = 0f;
        zoom.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            gameObject.SetActive(false);
            button.enabled = true;
            Time.timeScale = 1f;
            zoom.enabled = true;
        }
    }
}
