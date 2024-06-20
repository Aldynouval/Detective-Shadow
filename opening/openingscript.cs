using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class openingscript : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;
    [SerializeField] private GameObject Videoobject;
    [SerializeField] private VideoPlayer Video;
    bool canskip;
    void Start()
    {
        dialogue.SetActive(true);
        Video.loopPointReached += OnVideoFinished;
        canskip = false;
    }

    private void Update()
    {
        if (!dialogue.activeSelf)
        {
            canskip = true;
            Videoobject.SetActive(true);
        }

        if (canskip == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("stage 1");
            }
        }
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        if (!dialogue.activeSelf)
        {
            // Move to the next scene
            SceneManager.LoadScene("stage 1");
        }
    }

    private void OnDestroy()
    {
        // Unregister the event when the script is destroyed to avoid memory leaks
        Video.loopPointReached -= OnVideoFinished;
    }
}
