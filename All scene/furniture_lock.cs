using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furniture_lock : MonoBehaviour
{
    [SerializeField] private player_interact Player_Interact;
    [SerializeField] private player_inventrory player_Inventrory;
    [SerializeField] private GameObject dialogue;
    bool iscollide;

    private void Start()
    {
        iscollide = false;
    }
    private void Update()
    {
        if (iscollide == true)
        {
            if (player_Inventrory.iskey == false)
            {
                Player_Interact.enabled = false;
                StartCoroutine(enableinteract());
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (player_Inventrory.iskey == true)
                {
                    this.enabled = false;
                    player_Inventrory.key -= 1;
                }
                else
                {
                    dialogue.SetActive(true);
                }
            }
        }
    }

    private IEnumerator enableinteract()
    {
        yield return new WaitForSeconds(.01f);
        Player_Interact.enabled = true;
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
