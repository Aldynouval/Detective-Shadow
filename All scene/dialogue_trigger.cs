using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class dialogue_trigger : MonoBehaviour
{
    [SerializeField] private GameObject runningdialogue;
    bool rundialogue;
    public float wait;
    public bool triggerclick;
    public bool runafter;
    public bool disapear_after_trigger;

    private void Update()
    {
        if (rundialogue == true)
        {
            if (triggerclick == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (runafter == true)
                    {
                        StartCoroutine(playafter());
                        if (disapear_after_trigger == true)
                        {
                            this.enabled = false;
                        }
                    }
                    else
                    {
                        runningdialogue.SetActive(true);
                        if (disapear_after_trigger == true)
                        {
                            this.enabled = false;
                        }
                    }
                }
            }
            else
            {
                if (runafter == true)
                {
                    StartCoroutine(playafter());
                    if (disapear_after_trigger == true)
                    {
                        this.enabled = false;
                    }
                }
                else
                {
                    runningdialogue.SetActive(true);
                    if (disapear_after_trigger == true)
                    {
                        this.enabled = false;
                    }
                }
            }
        }
    }

    private IEnumerator playafter()
    {
        yield return new WaitForSeconds(wait);
        runningdialogue.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rundialogue = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rundialogue = false;
        }
    }

}
