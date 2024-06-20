using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective3_2 : MonoBehaviour
{
    public bool objective3_complete;
    bool canstartobjective;
    [SerializeField] GameObject block;
    private void Update()
    {
        if (canstartobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            objective3_complete = true;
            StartCoroutine(disable());
            block.SetActive(false);
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
