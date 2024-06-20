using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_furniture_lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    private objective4_2 furniture_Interact;
    [SerializeField] private GameObject dialogue;

    [SerializeField] private objective3_2 Objective;

    bool interact;

    // Update is called once per frame
    private void Start()
    {
        furniture_Interact = gameObject.GetComponent<objective4_2>();
        furniture_Interact.enabled = false;
    }

    void Update()
    {
        if (Objective.objective3_complete == false)
        {
            if (interact == true && Input.GetKeyDown(KeyCode.E))
            {
                dialogue.SetActive(true);
            }
        }
        else
        {
            furniture_Interact.enabled = true;
            this.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;
        }
    }
}
