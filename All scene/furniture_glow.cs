using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furniture_glow : MonoBehaviour
{
    [SerializeField] private Sprite normal, triggered;
    [SerializeField] private SpriteRenderer thisobject;

    bool objectglow;

    private void Start()
    {
        thisobject = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        glow();
    }

    private void glow()
    {
        if (objectglow == true)
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
            objectglow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objectglow = false;
        }
    }
}
