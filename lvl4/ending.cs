using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ending : MonoBehaviour
{
    [SerializeField] private GameObject Videoobject;
    [SerializeField] private VideoPlayer Video;
    [SerializeField] private GameObject text;
    void Start()
    {
        Video.loopPointReached += OnVideoFinished;
    }

    private void Update()
    {
        if (!Videoobject.activeSelf)
        {
            text.SetActive(true);

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("Tittle screen");
            }
        }
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        Videoobject.SetActive(false);
    }

    private void OnDestroy()
    {
        // Unregister the event when the script is destroyed to avoid memory leaks
        Video.loopPointReached -= OnVideoFinished;
    }
}
