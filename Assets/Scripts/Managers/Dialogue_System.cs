using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_System : MonoBehaviour
{
    public static Dialogue_System Instance;

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lines == null || lines.Length == 0)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }

    }

    public void StartDialogue(string[] dialogueLine)
    {
        index = 0;

        lines = dialogueLine;

        dialogueBox.SetActive(true);
        dialogueText.text = string.Empty;
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach(char c in lines[index])
        {
            isTyping = true;
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeText());
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        dialogueBox.SetActive(false);
    }
}
