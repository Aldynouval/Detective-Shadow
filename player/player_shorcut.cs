using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shorcut : MonoBehaviour
{
    [SerializeField] private Pause_UI Pause_UI;
    [SerializeField] private Objective_UI objective_UI;

    // Update is called once per frame
    void Update()
    {
        //pause
        if (Pause_UI.pause == false && objective_UI.show == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause_UI.PauseGame();
            }
        }
        else if (Pause_UI.pause == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause_UI.ResumeGame();
            }
        }
        //end of pause

        //objective
        if (objective_UI.show == false && Pause_UI.pause == false)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                objective_UI.showobjective();
            }
        }
        else if (objective_UI.show == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                objective_UI.hideobjective();
            }
        }
        //end of objective
    }
}
