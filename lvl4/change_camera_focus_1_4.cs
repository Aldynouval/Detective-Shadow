using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class change_camera_focus_1_4 : MonoBehaviour
{
    bool collide;
    [SerializeField] private CinemachineVirtualCamera cam;
    [SerializeField] private Transform target;
    [SerializeField] private Transform player;
    [SerializeField] private BoxCollider2D electric;
    [SerializeField] private GameObject Dialogue;

    private void Start()
    {
        electric.enabled = false;
    }

    private void Update()
    {
        if (collide == true)
        {
            cam.Follow = target;
            electric.enabled = true;
            StartCoroutine(normal());
            StartCoroutine(destroy());
            StartCoroutine(dialogue());
            transform.position = new Vector2(100, 0);
        }
    }

    private IEnumerator normal()
    {
        yield return new WaitForSeconds(2);
        cam.Follow = player;
    }

    private IEnumerator dialogue()
    {
        yield return new WaitForSeconds(2.5f);
        Dialogue.SetActive(true);
    }

    private IEnumerator destroy()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
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
