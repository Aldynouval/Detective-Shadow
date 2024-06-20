using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KEY : MonoBehaviour
{
    [SerializeField] public player_inventrory inventory;
    bool collide;
    [SerializeField] private int key_amount;

    private void Update()
    {
        if (collide == true && Input.GetKeyDown(KeyCode.E))
        {
            inventory.key += key_amount;
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
