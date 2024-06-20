using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cctv_move : MonoBehaviour
{
    float speed = 20;

    private void Update()
    {
        if (Time.timeScale != 0)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            speed = -speed;
        }
    }
}
