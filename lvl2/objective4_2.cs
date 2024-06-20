using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class objective4_2 : MonoBehaviour
{
    public bool objective4_complete;
    bool canstartobjective;

    [SerializeField] private BoxCollider2D lift;
    [SerializeField] private GameObject panel;

    private void Start()
    {
        lift.enabled = false;
    }
    private void Update()
    {
        if (canstartobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            objective4_complete = true;
            lift.enabled=true;
            panel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canstartobjective = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canstartobjective = false;
        }
    }
}
