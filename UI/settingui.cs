using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class settingui : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            back();
        }
    }

    public void back()
    {
        gameObject.SetActive(false);
    }

    public void deletedata()
    {
        PlayerPrefs.DeleteAll();
    }
}
