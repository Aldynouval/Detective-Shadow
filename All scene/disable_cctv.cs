using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_cctv : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private player_interact player;
    bool collide;

    private void Update()
    {
        if (collide == true && player.candisablecctv == true)
        {
            target.SetActive(false);
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
