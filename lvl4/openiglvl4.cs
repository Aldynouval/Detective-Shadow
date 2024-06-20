using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openiglvl4 : MonoBehaviour
{
    private AudioSource ring;
    [SerializeField] private GameObject dialogue;
    [SerializeField] private player_control player;

    private void Start()
    {
        ring = GetComponent<AudioSource>(); 
        ring.enabled = false;
        player.speed = 0;
    }
    private void OnDisable()
    {
       player.speed = player.samespeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ring.enabled = true;
            StartCoroutine(stopring());
            StartCoroutine(destroy());
        }
    }

    IEnumerator stopring()
    {
        yield return new WaitForSeconds(1.5f);
        ring.enabled = false;
        dialogue.SetActive(true);
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(1.6f);
        gameObject.SetActive(false);
    }
}
