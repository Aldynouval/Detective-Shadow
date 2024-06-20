using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class guard_patrol : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float samespeed;
    private Animator Animation;

    private Rigidbody2D rb;
    private Transform tr;

    public float waitforsecond = 5;

    bool isfacingright;
    bool stop;

    private void Start()
    {
        speed = 5;
        samespeed = speed;
        waitforsecond = 5;
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        Animation = GetComponent<Animator>();
        Animation.SetBool("iswalking", true);
    }
    void Update()
    {
        move();
        facing();

        if (Time.timeScale == 0)
        {
            stop = true;
        }
        if (Time.timeScale == 1)
        {
            stop = false;
        }
    }

    private void move()
    {
        if (stop == false)
        {
            if (isfacingright == true)
            {
                rb.velocity = new Vector2(speed, 0);
            }
            else
            {
                rb.velocity = new Vector2(-speed, 0);
            }
        }
    }

    private void facing()
    {
        if (tr.localScale.x > 0)
        {
            isfacingright = true;
        }
        if (tr.localScale.x < 0)
        {
            isfacingright = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            speed = 0;
            Animation.SetBool("iswalking", false);
            StartCoroutine(flip());
        }
    }

    private IEnumerator flip()
    {
        yield return new WaitForSeconds(waitforsecond);
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
        Animation.SetBool("iswalking", true);

        //return speed
        speed = samespeed;
    }
}
