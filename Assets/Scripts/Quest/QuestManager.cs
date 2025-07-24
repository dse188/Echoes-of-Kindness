using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    [SerializeField] private GameObject questMenu;
    [SerializeField] private TextMeshProUGUI questText;

    private List<Quest_SO> activateQuests = new List<Quest_SO>();
    private bool isMenuOpen = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ToggleQuestMenu();
        }
    }

    public void ActivateQuest(Quest_SO quest)
    {
        if (activateQuests.Contains(quest) == false)
        {
            activateQuests.Add(quest);
            Debug.Log("Qeust activated: " + quest.questName);
            UpdateQuestGUI(quest);
        }
    }

    private void UpdateQuestGUI(Quest_SO quest)
    {
        questMenu.SetActive(true);
        questText.text = quest.name + "\n" + quest.description;
    }

    private void ToggleQuestMenu()
    {
        isMenuOpen = !isMenuOpen;
        questMenu.SetActive(isMenuOpen);

        if(isMenuOpen && activateQuests.Count > 0)
        {
            UpdateQuestGUI(activateQuests[activateQuests.Count - 1]);
        }
    }

}
