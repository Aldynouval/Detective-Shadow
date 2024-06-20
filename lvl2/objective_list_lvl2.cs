using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class objective_list_lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI obj1;
    [SerializeField] private TextMeshProUGUI obj2;
    [SerializeField] private TextMeshProUGUI obj3;
    [SerializeField] private TextMeshProUGUI obj4;
    [SerializeField] private TextMeshProUGUI obj5;

    [SerializeField] objective1_2 objective1;
    [SerializeField] objective2_2 objective2;
    [SerializeField] objective3_2 objective3;
    [SerializeField] objective4_2 objective4;
    [SerializeField] objective5_2 objective5;

    private void Start()
    {
        obj2.enabled = false;
        obj3.enabled = false;
        obj4.enabled = false;
        obj5.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (objective1.objective1_complete == true)
        {
            obj1.fontStyle = FontStyles.Strikethrough;
            obj2.enabled = true;
        }

        if (objective2.objective2_complete == true)
        {
            obj2.fontStyle = FontStyles.Strikethrough;
            obj3.enabled = true;
        }

        if (objective3.objective3_complete == true)
        {
            obj3.fontStyle = FontStyles.Strikethrough;
            obj4.enabled = true;
        }

        if (objective4.objective4_complete == true)
        {
            obj4.fontStyle = FontStyles.Strikethrough;
            obj5.enabled = true;
        }

        if (objective5.objective5_complete == true)
        {
            obj5.fontStyle = FontStyles.Strikethrough;
        }
    }
}
