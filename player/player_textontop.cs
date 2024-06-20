using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player_textontop : MonoBehaviour
{
    [SerializeField] private TextMeshPro interacttxt, usedoortxt, hide, unhide;

    private Vector3 offset = new Vector3(0, 1, -0.1f);
    [SerializeField] private Transform target;

    [SerializeField] private player_interact player;
    [SerializeField] private player_control player_hide;
    [SerializeField] private player_usedoor Usedoor;


    private void Start()
    {
        interacttxt.enabled = false;
        usedoortxt.enabled = false;
        hide.enabled = false;
        unhide.enabled = false;
    }

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = targetPosition;

        // interact
        if (player.caninteract == true || player.caninteractobjective == true || player.caninteracoother == true || player.caninteractelectric)
        {
            interacttxt.enabled = true;
        }
        else
        {
            interacttxt.enabled = false;
        }
        // end of interact

        // door interact
        if (Usedoor.canusedoor == true)
        {
            usedoortxt.enabled = true;
        }
        else
        {
            usedoortxt.enabled = false;
        }
        // door end of interact

        // hide interact
        if (player_hide.iscanhide == true && player_hide.ishiding == false)
        {
            hide.enabled = true;
        }
        else
        {
            hide.enabled = false;
        }
        // unhide intract
        if (player_hide.ishiding == true)
        {
            unhide.enabled = true;
        }
        else
        {
            unhide.enabled = false;
        }
        // end
    }
}
