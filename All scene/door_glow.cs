using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_glow : MonoBehaviour
{
    [SerializeField] private Sprite normal, triggered;
    [SerializeField] private SpriteRenderer thisobject;
    bool iscaninteract;

    private void Start()
    {
        thisobject = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        interact();
    }

    private void interact()
    {
        if (iscaninteract == true)
        {
            thisobject.sprite = triggered;
        }
        else
        {
            thisobject.sprite = normal;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            iscaninteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            iscaninteract = false;
        }
    }
}
