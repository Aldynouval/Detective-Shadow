using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective1_4 : MonoBehaviour
{
    bool collide;

    [SerializeField] private objective2_4 obj2; 

    private void Update()
    {
        if (collide == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                obj2.proof += 1;
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
