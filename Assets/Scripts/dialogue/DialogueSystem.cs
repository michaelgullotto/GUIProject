using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance { get; set; }
    public string npcname;
    public GameObject dialoguepannel;
    public List<string> dialogueLines = new List<string>();

    public Button continueButton;
    public Text dialogueText, nameText;
    int dialogueIndex = 0;
    private void Awake()
    {
        continueButton = dialoguepannel.transform.Find("continue").GetComponent<Button>();
        nameText = dialoguepannel.transform.Find("npcname").GetComponent<Text>();
        dialogueText = dialoguepannel.transform.Find("diaText").GetComponent<Text>();
        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
        dialoguepannel.SetActive(false);

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
            instance = this;
    }

    // Update is called once per frame
   public void AddNewDialogue(string[] lines, string npcname)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(lines.Length);
        dialogueLines.AddRange(lines);
        this.npcname = npcname;
        Debug.Log(dialogueLines.Count);
        CreateDialogue();

        

    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcname;
        dialoguepannel.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if (dialogueIndex < dialogueLines.Count -1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguepannel.SetActive(false);
        }
    }
}
