using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonhover : MonoBehaviour
{
    private AudioSource click;

    private void Start()
    {
        click = GetComponent<AudioSource>();
    }
    public void mousehover()
    {
        transform.localScale = new Vector2 (1.2f,1.2f);
        click.Play ();
    }
    public void mouseunhover()
    {
        transform.localScale = new Vector2(1, 1);
    }
}
