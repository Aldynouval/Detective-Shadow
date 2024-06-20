using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locker : MonoBehaviour
{
    private Transform destination;
    [SerializeField] player_control player;
    private AudioSource Audio;
    bool collide;

    private void Start()
    {
        destination = gameObject.GetComponent<Transform>();
        Audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (collide == true && Input.GetKeyDown(KeyCode.E))
        {
            Audio.Play();
        }
    }

    public Transform GetDestination()
    {
        return destination;
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
