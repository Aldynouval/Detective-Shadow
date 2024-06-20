using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective1_2 : MonoBehaviour
{
    public bool objective1_complete;
    bool canstartobjective;
    [SerializeField] private disable_door target;

    private void Update()
    {
        if (canstartobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            objective1_complete = true;
            StartCoroutine(disable());
            target.enabled = false;
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
            canstartobjective = true ;
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
