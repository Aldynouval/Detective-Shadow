using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class door : MonoBehaviour
{
    [SerializeField] private Transform destination;
    bool doorsound;
    private AudioSource doorslam;

    private void Start()
    {
        doorslam = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Time.timeScale != 0)
        {
            if (doorsound == true && Input.GetKeyDown(KeyCode.E))
            {
                doorslam.Play();
            }
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
            doorsound = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorsound = false;
        }
    }
}
