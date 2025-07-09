using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance;

    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private float textSpeed;

    private string[] lines;
    private int index;
    private bool isTyping;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if(!dialogueBox.activeSelf)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
                isTyping = false;
            }
            else
            {
                NextLine();
            }
        }
    }

    public void StartDialogue(string[] newLines)
    {
        lines = newLines;
        index = 0;
        dialogueBox.SetActive(true);
        dialogueText.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        dialogueText.text = string.Empty;

        foreach (char c in lines[index])
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        isTyping = false;
    }

    private void NextLine()
    {
        if(++index < lines.Length)
        {
            StartCoroutine(TypeLine());
        }
        else
        {
            EndDialogue();
        }
    }

    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
    }
}
