using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective5_2 : MonoBehaviour
{
    public bool objective5_complete;
    bool canstartobjective;

    [SerializeField] private GameObject finish_ui;
    [SerializeField] private objective4_2 obj4;
    [SerializeField] private GameObject flag;

    private void Start()
    {
        flag.SetActive(false);
    }
    private void Update()
    {
        if (canstartobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            objective5_complete = true;
            StartCoroutine(disable());
            

            finish_ui.SetActive(true);
        }

        if (obj4.objective4_complete == true)
        {
            flag.SetActive(true);
        }
    }

    private IEnumerator disable()
    {
        yield return new WaitForSeconds(0.1f);
        this.enabled = false;
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
