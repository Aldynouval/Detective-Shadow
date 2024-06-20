using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactive_furniture : MonoBehaviour
{
    [SerializeField] private BoxCollider2D thiscollider;
    bool thiscollide;

    private void Start()
    {
        thiscollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (thiscollide == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(wait());
        }
    }


    private IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f);
        thiscollider.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            thiscollide = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            thiscollide = false;
        }
    }
}
