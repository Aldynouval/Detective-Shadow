using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class objective_list : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI obj1;
    [SerializeField] private TextMeshProUGUI obj2;
    [SerializeField] private TextMeshProUGUI obj3;
    [SerializeField] private TextMeshProUGUI obj4;

    [SerializeField] objective1 objective1;
    [SerializeField] objective2 objective2;
    [SerializeField] objective3 objective3;
    [SerializeField] objective4 objective4;

    private void Start()
    {
        obj2.enabled = false;
        obj3.enabled = false;
        obj4.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (objective1.objective1_complete == true)
        {
            obj1.fontStyle = FontStyles.Strikethrough;
            obj2.enabled = true;
            obj3.enabled = true;
        }

        if (objective2.objective2_complete == true)
        {
            obj2.fontStyle = FontStyles.Strikethrough;
        }

        if (objective3.objective3_complete == true)
        {
            obj3.fontStyle = FontStyles.Strikethrough;
        }

        if (objective2.objective2_complete == true && objective3.objective3_complete == true)
        {
            obj4.enabled= true;
        }

        if (objective4.objective4_complete == true)
        {
            obj4.fontStyle = FontStyles.Strikethrough;
        }
    }
}
