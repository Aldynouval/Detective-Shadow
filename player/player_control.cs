using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public float horizontal;
    public float speed;
    public float samespeed;
    public float sneak_speed;

    bool isfacingright;
    public bool ishiding;
    public bool iscanhide;
    public bool issneak;
    public bool iswalking;

    private GameObject currentlocker;

    private SpriteRenderer playersprite;
    private Rigidbody2D rb;
    private Animator Animator;

    [SerializeField] private AudioSource foostep;

    internal Vector3 position;

    private player_interact player_Interact;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        samespeed = speed;
        isfacingright = true;
        rb = GetComponent<Rigidbody2D>();
        playersprite = GetComponent<SpriteRenderer>();
        foostep = GetComponent<AudioSource>();
        player_Interact = GetComponent<player_interact>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        facing();
        sneak();
        hide();
        footsteps();
        Animation();

        if (player_Interact.doinginteract == true)
        {
            rb.drag = 100;
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void Animation()
    {
        if (Time.timeScale != 0)
        {
            if (issneak == true)
            {
                Animator.SetBool("sneak", true);
            }
            else
            {
                Animator.SetBool("sneak", false);
            }

            if (player_Interact.doinginteract == true)
            {
                Animator.SetBool("collect", true);
            }
            else
            {
                Animator.SetBool("collect", false);
            }

            Animator.SetFloat("speed", Mathf.Abs(horizontal));
        }
    }

    private void footsteps()
    {
        if (iswalking == true)
        {
            if (issneak == false)
            {
                foostep.enabled = true;
            }
            else
            {
                foostep.enabled = false;
            }
        }
        else
        {
            foostep.enabled = false;
        }

        if (Time.timeScale == 0)
        {
            foostep.enabled = false;
        }

        if (speed == 0)
        {
            foostep.enabled = false;
        }

        if (player_Interact.doinginteract == true)
        {
            foostep.enabled = false;
        }

    }

    private void move()
    {
        if (ishiding == false && player_Interact.doinginteract == false && Time.timeScale != 0)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

            if (horizontal != 0)
            {
                iswalking = true;
            }
            else
            {
                iswalking = false;
            }
        }
    }

    private void facing()
    {
        if (Time.timeScale != 0)
        {
            if (ishiding == false && (isfacingright && horizontal < 0f || !isfacingright && horizontal > 0f))
            {
                isfacingright = !isfacingright;

                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
        }
    }

    private void sneak()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            issneak = true;
            speed /= sneak_speed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            issneak = false;
            speed = samespeed;
        }
    }

    private void hide()
    {
        if (iscanhide && Input.GetKeyDown(KeyCode.E))
        {
            ishiding = !ishiding;

            if (ishiding)
            {
                horizontal = 0f;
                iswalking = false;
                playersprite.enabled = false;
                rb.velocity = Vector3.zero;
                transform.position = currentlocker.GetComponent<locker>().GetDestination().position;
            }
            else
            {
                playersprite.enabled = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hidespot"))
        {
            iscanhide = true;
            currentlocker = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("hidespot"))
        {
            iscanhide = false;

            if (collision.gameObject == currentlocker)
            {
                currentlocker = null;
            }
        }
    }
}
