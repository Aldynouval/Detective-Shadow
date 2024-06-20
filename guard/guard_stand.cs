using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class guard_stand : MonoBehaviour
{
    public float waitforsecond;
    private bool facingRight = true;
    bool canflip = true;

    void Start()
    {
        StartCoroutine(flip());
    }

    private IEnumerator flip()
    {
        while (canflip)
        {
            yield return new WaitForSeconds(waitforsecond);

            if (facingRight)
            {
                transform.localScale = new Vector2(-transform.localScale.x , transform.localScale.y);
            }
            else
            {
                transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
            }
            facingRight = !facingRight;
        }
    }
}
