using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Quest/New Quest")]
public class Quest_SO : ScriptableObject
{
    public string questName;
    [TextArea] public string description;
    public string[] objectives;
    public bool isCompleted;
}
