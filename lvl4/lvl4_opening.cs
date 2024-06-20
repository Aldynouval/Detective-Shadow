using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class lvl4_opening : MonoBehaviour
{
    [SerializeField] private GameObject Videoobject;
    [SerializeField] private VideoPlayer Video;
    void Start()
    {
        Video.loopPointReached += OnVideoFinished;
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene("stage 4");
    }

    private void OnDestroy()
    {
        // Unregister the event when the script is destroyed to avoid memory leaks
        Video.loopPointReached -= OnVideoFinished;
    }
}
