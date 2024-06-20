using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective3_3_1 : MonoBehaviour
{
    bool collide;
    public bool obj3_complete;

    private void Update()
    {
        if (collide == true && Input.GetKeyDown(KeyCode.E))
        {
            obj3_complete = true;
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
