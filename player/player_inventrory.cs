using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_inventrory : MonoBehaviour
{
    public int key;
    public bool iskey;

    private void Start()
    {
        key = 0;
    }
    private void Update()
    {
        if (key >= 1)
        {
            iskey = true;
        }
        if (key <= 0)
        {
            iskey = false;
        }
    }
}
