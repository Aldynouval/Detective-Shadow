using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective1 : MonoBehaviour
{
    public bool objective1_complete;
    bool canstartobjective;
    AudioSource Audio;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();   
    }

    private void Update()
    {
        if (canstartobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            objective1_complete = true;
            StartCoroutine(disable());
            Audio.enabled = false;
        }

        if (Time.timeScale == 0)
        {
            Audio.Pause();
        }
        else
        {
            Audio.UnPause();
        }
    }

    private IEnumerator disable()
    {
        yield return new WaitForSeconds(0.1f);
        this.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canstartobjective = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canstartobjective = false;
        }
    }
}
