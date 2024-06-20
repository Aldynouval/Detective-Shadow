using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_door : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject dialogue;
    [SerializeField] private player_usedoor Usedoor;
    private AudioSource Audio;

    bool interact;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.enabled = false;
    }

    private void OnDisable()
    {
        Audio.enabled = true;
    }

    void Update()
    {
        if (interact == true)
        {
            Usedoor.enabled = false;
            StartCoroutine(enableusedoor());

            if (Input.GetKey(KeyCode.E))
            {
                dialogue.SetActive(true); 
            }
        }
    }

    private IEnumerator enableusedoor()
    {
        yield return new WaitForSeconds(.01f);
        Usedoor.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;
        }
    }
}
