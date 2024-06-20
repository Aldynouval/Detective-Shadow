using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_furniture_lvl1 : MonoBehaviour
{
    [SerializeField] private BoxCollider2D thisboxcollider;
    [SerializeField] private objective1 obj1;
    // Update is called once per frame
    private void Start()
    {
        thisboxcollider = GetComponent<BoxCollider2D>();
        thisboxcollider.enabled = false;
    }

    void Update()
    {
        if (obj1.objective1_complete == true)
        {
            thisboxcollider.enabled = true;
            this.enabled = false;
        }
    }
}
