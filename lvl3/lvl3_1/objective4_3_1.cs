using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective4_3_1 : MonoBehaviour
{
    bool collide;
    [SerializeField] private objective1_3_1 obj1;
    [SerializeField] private objective2_3_1 obj2;
    [SerializeField] private objective3_3_1 obj3;

    [SerializeField] private GameObject dialogue;
    [SerializeField] private BoxCollider2D lift;

    private BoxCollider2D thisbc;
    private SpriteRenderer thissp;

    bool isdone;
    bool isrun;

    private void Start()
    {
        thisbc = GetComponent<BoxCollider2D>();
        thissp = GetComponent<SpriteRenderer>();
        thisbc.enabled = false;
        thissp.enabled = false;
        lift.enabled = false;
    }

    private void Update()
    {
        if (obj1.obj1_complete == true && obj2.obj2_complete == true && obj3.obj3_complete == true)
        {
            thisbc.enabled = true;
            thissp.enabled = true;
            lift.enabled = true;
            isdone = true;
        }

        if (isdone == true && isrun == false)
        {
            StartCoroutine(setactive());
            isrun = true;
        }

        if (collide == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("stage 3-2");
        }
    }

    IEnumerator setactive()
    {
        yield return new WaitForSeconds(5f);
        {
            dialogue.SetActive(true);
        }
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
