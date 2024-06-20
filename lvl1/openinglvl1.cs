using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class openinglvl1 : MonoBehaviour
{
    [SerializeField] private GameObject startdialoguetrigger;
    [SerializeField] private CinemachineVirtualCamera cam;
    [SerializeField] private Transform player;
    [SerializeField] private player_control Player_Control;
    // Start is called before the first frame update

    private void Start()
    {
        Player_Control.enabled = false;
    }
    IEnumerator followplayer()
    {
        yield return new WaitForSeconds(3);
        cam.Follow = player;
    }

    IEnumerator playdialogue()
    {
        yield return new WaitForSeconds(4);
        startdialoguetrigger.SetActive(true);
        Player_Control.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(followplayer());
        StartCoroutine(playdialogue());
        gameObject.transform.position = new Vector2(0, 100);
    }
}
