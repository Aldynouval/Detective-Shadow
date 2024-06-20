using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class customdialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;

    public float textSpeed;
    private int index;

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
            }
        }
    }

    void StartDialogue()
    {
        Time.timeScale = 0f;
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
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
