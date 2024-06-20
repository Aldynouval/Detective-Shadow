using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unlock_next_level : MonoBehaviour
{
    public int nextsceneload;

    private void Start()
    {
        nextsceneload = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (nextsceneload > PlayerPrefs.GetInt("level_at"))
            {
                PlayerPrefs.SetInt("level_at", nextsceneload);
            }
        }
        this.enabled = false;
    }
}
