using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective3 : MonoBehaviour
{
    public bool objective3_complete;
    bool canstartobjective;
    [SerializeField] private Animator player;
    [SerializeField] private RuntimeAnimatorController sleep, normal;

    private void Start()
    {
        player.runtimeAnimatorController = sleep;
    }
    private void Update()
    {
        if (canstartobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            objective3_complete = true;
            StartCoroutine(disable());
            StartCoroutine(changeclothe());
        }
    }

    private IEnumerator disable()
    {
        yield return new WaitForSeconds(0.1f);
        this.enabled = false;
    }
    private IEnumerator changeclothe()
    {
        yield return new WaitForSeconds(5f);
        player.runtimeAnimatorController = normal;
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
