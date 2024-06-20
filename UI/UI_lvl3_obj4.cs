using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_lvl3_obj4 : MonoBehaviour
{
    [SerializeField] private GameObject nextpanel;
    [SerializeField] private GameObject prevpanel;
    [SerializeField] private player_shorcut player_Shorcut;
 
    private void OnEnable()
    {
        Time.timeScale = 0f;
        player_Shorcut.enabled = false;
    }
    public void next()
    {
        nextpanel.SetActive(true);
        gameObject.SetActive(false);
    }

    public void prev()
    {
        prevpanel.SetActive(true);
        gameObject.SetActive(false);
    }
    public void exit()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
        player_Shorcut.enabled = true;
    }
}
