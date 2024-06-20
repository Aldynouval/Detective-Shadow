using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective2_4 : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;
    private BoxCollider2D thisbc;
    private SpriteRenderer thissp;

    public int proof;

    bool collide;
    bool isrun;

    private void Start()
    {
        thissp = GetComponent<SpriteRenderer>();
        thisbc = GetComponent<BoxCollider2D>();
        thisbc.enabled = false;
        thissp.enabled = false;
    }
    private void Update()
    {
        if (proof == 17)
        {
            if (isrun == false)
            {
                dialogue.SetActive(true);
                isrun = true;
            }

            thisbc.enabled = true;
            thissp.enabled = true;

            if (collide == true)
            {
                SceneManager.LoadScene("ending");
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collide = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collide = false;
        }
    }
}
