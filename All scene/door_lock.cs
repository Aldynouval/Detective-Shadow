using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_lock : MonoBehaviour
{
    [SerializeField] private player_usedoor player_Usedoor;
    [SerializeField] private player_inventrory player_Inventrory;
    [SerializeField] private GameObject dialogue;
    private AudioSource doorslam;
    bool iscollide;

    private void Start()
    {
        iscollide = false;
        doorslam = GetComponent<AudioSource>();
        doorslam.enabled = false;
    }
    private void Update()
    {
        if (Time.timeScale != 0)
        {
            if (iscollide == true)
            {
                if (player_Inventrory.iskey == false)
                {
                    player_Usedoor.enabled = false;
                    StartCoroutine(enableusedoor());
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (player_Inventrory.iskey == true)
                    {
                        this.enabled = false;
                        player_Inventrory.key -= 1;
                        doorslam.enabled = true;
                        doorslam.Play();
                    }
                    else
                    {
                        dialogue.SetActive(true);
                    }
                }
            }
        }
    }

    private IEnumerator enableusedoor()
    {
        yield return new WaitForSeconds(.01f);
        player_Usedoor.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            iscollide = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            iscollide = false;
        }
    }
}
