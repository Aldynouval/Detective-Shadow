using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_interact : MonoBehaviour
{
    private player_control player;

    public bool caninteract;
    public bool caninteractobjective;
    public bool caninteractelectric;
    public bool caninteracoother;

    public bool candisablecctv;
    public bool doinginteract;

    [SerializeField] private AudioSource interactsound;

    private void Start()
    {
        player = GetComponent<player_control>();
    }
    void Update()
    {
        usefurniture();
        usefurniture_objective();
        usefurnitureelectric();

        if (doinginteract == true)
        {
            interactsound.enabled = true;
            player.iswalking = false;

            if (Time.timeScale == 0)
            {
                interactsound.Pause();
            }
            else if (Time.timeScale != 0)
            {
                interactsound.UnPause();
            }
        }
    }

    private void usefurniture()
    {
        if (caninteract == true && Input.GetKeyDown(KeyCode.E))
        {
            //play animation here
            player.speed = 0;
            doinginteract = true;
            StartCoroutine(backtonormalafterinteract());
        }
    }

    private void usefurnitureelectric()
    {
        if (caninteractelectric == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                candisablecctv = true;
                //play animation here
                player.speed = 0;
                doinginteract = true;
                StartCoroutine(backtonormalafterinteractelectric());
            }
        }
    }

    private void usefurniture_objective()
    {
        if (caninteractobjective == true && Input.GetKeyDown(KeyCode.E))
        {
            //play animation here
            player.speed = 0;
            doinginteract = true;
            StartCoroutine(backtonormalafterinteractobjective());
        }
    }

    private IEnumerator backtonormalafterinteractobjective()
    {
        yield return new WaitForSeconds(5);
        //play animation here
        if (player.issneak == true)
        {
            player.speed = player.samespeed / player.sneak_speed;
        }
        else
        {
            player.speed = player.samespeed;
        }

        interactsound.enabled = false;
        doinginteract = false;
    }

    private IEnumerator backtonormalafterinteract()
    {
        yield return new WaitForSeconds(1);
        //play animation here
        if (player.issneak == true)
        {
            player.speed = player.samespeed / player.sneak_speed;
        }
        else
        {
            player.speed = player.samespeed;
        }

        interactsound.enabled = false;
        doinginteract = false;
    }

    private IEnumerator backtonormalafterinteractelectric()
    {
        yield return new WaitForSeconds(5);
        //play animation here
        if (player.issneak == true)
        {
            player.speed = player.samespeed / player.sneak_speed;
        }
        else
        {
            player.speed = player.samespeed;
        }
        
        candisablecctv = false;
        interactsound.enabled = false;
        doinginteract = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("furniture"))
        {
            caninteract = true;
        }

        if (collision.CompareTag("furnitureobjective"))
        {
            caninteractobjective = true;
        }

        if (collision.CompareTag("furnitureelectric"))
        {
            caninteractelectric = true;
        }

        if (collision.CompareTag("furnitureother"))
        {
            caninteracoother = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("furniture"))
        {
            caninteract = false;
        }

        if (collision.CompareTag("furnitureobjective"))
        {
            caninteractobjective = false;
        }

        if (collision.CompareTag("furnitureelectric"))
        {
            caninteractelectric = false;
        }

        if (collision.CompareTag("furnitureother"))
        {
            caninteracoother = false;
        }
    }
}
