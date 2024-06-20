using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_progression : MonoBehaviour
{
    public Button[] levelbutton;

    private void Start()
    {
        int level_at = PlayerPrefs.GetInt("level_at", 2);

        for (int i = 0; i < levelbutton.Length; i++)
        {
            if (i + 2 > level_at)
            {
                levelbutton[i].interactable = false;
            }
        }
    }
}
