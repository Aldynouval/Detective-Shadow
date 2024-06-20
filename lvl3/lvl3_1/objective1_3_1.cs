using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective1_3_1 : MonoBehaviour
{
    bool collide;
    public bool obj1_complete;

    private void Update()
    {
        if (collide == true && Input.GetKeyDown(KeyCode.E))
        {
            obj1_complete = true;
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
