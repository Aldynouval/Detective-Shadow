using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_usedoor : MonoBehaviour
{
    private GameObject currentDoor;
    public bool canusedoor;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            usedoor();
        }
    }

    private void usedoor()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentDoor == true)
            {
                transform.position = currentDoor.GetComponent<door>().GetDestination().position;
            }
            else
            {
                transform.position = gameObject.transform.position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("door"))
        {
            canusedoor = true;
            currentDoor = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("door"))
        {
            canusedoor = false;

            if (collision.gameObject == currentDoor)
            {
                currentDoor = null;
            }
        }
    }
}
