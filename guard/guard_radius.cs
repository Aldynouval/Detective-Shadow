using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard_radius : MonoBehaviour
{
    bool onradius;
    [SerializeField] private GameObject eye, ear;

    private void Start()
    {
        eye.GetComponent<SpriteRenderer>().enabled = false;
        ear.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        if (onradius == true)
        {
            eye.SetActive(true);
            ear.SetActive(true);
        }
        else
        {
            eye.SetActive(false);
            ear.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onradius = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onradius = false;
        }
    }
}
