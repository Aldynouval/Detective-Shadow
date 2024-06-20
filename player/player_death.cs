using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_death : MonoBehaviour
{
    public bool onvision;
    public bool onhearing;

    private player_control player;

    private void Start()
    {
        player = GetComponent<player_control>();
    }

    private void Update()
    {
        //onvision
        if (onvision == true && player.ishiding == false)
        {
            StartCoroutine(deathwait());
        }

        //onhearing
        if (player.ishiding == false)
        {
            if (onhearing == true && player.issneak == false && player.iswalking == true)
            {
                StartCoroutine(deathwait());
            }
        }
    }

    private IEnumerator deathwait()
    {
        yield return new WaitForSeconds(.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("vision"))
        {
            onvision = true;
        }

        if (collision.CompareTag("hearing"))
        {
            onhearing = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("vision"))
        {
            onvision = false;
        }

        if (collision.CompareTag("hearing"))
        {
            onhearing = false;
        }
    }
}
