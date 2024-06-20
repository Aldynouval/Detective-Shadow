using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective4 : MonoBehaviour
{
    [SerializeField] private objective1 obj1;
    [SerializeField] private objective2 obj2;
    [SerializeField] private objective3 obj3;

    public bool objective4_complete;

    [SerializeField] private GameObject finishtrigger;
    [SerializeField] private GameObject finish_ui;
    [SerializeField] private GameObject dialogue;

    bool collide;
    bool isplay = false;

    private void Update()
    {
        if (obj1.objective1_complete && obj2.objective2_complete && obj3.objective3_complete)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            if (isplay == false)
            {
                StartCoroutine(play());
                isplay = true;
            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (collide == true && obj1.objective1_complete && obj2.objective2_complete && obj3.objective3_complete)
        {
            objective4_complete = true;
            finish_ui.SetActive(true);
        }
    }

    private IEnumerator play()
    {
        yield return new WaitForSeconds(5.1f);
        dialogue.SetActive(true);
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
