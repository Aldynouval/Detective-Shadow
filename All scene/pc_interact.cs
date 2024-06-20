using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pc_interact : MonoBehaviour
{
    [SerializeField] private GameObject screen;
    bool canuse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canuse == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                screen.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canuse = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canuse = false;
        }
    }
}
