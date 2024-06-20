using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI speakername;
    public string[] nameline;

    public TextMeshProUGUI textComponent;
    public string[] lines;

    public float textSpeed;
    private int index;

    public bool dialogue_on;

    [SerializeField] private player_shorcut button;
    [SerializeField] private camera zoom;
    [SerializeField] private AudioSource Audio;

    // Start is called before the first frame update
    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    void OnEnable()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                speakername.text = nameline[index];
            }
        }

        if (dialogue_on == true)
        {
            button.enabled = false;
            zoom.enabled = false;
        }
        else
        {
            button.enabled = true;
            zoom.enabled = true;
        }
    }

    void StartDialogue()
    {
        Time.timeScale = 0f;
        index = 0;
        StartCoroutine(TypeLine());
        dialogue_on = true;
    }

    IEnumerator TypeLine()
    {
        speakername.text = nameline[index];
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return WaitForRealSeconds(textSpeed);
            Audio.Play();
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
            dialogue_on = false;
        }
    }

    IEnumerator WaitForRealSeconds(float time)
    {
        float startTime = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < startTime + time)
        {
            yield return null;
        }
    }
}