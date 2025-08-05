using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Show_Velocity : MonoBehaviour
{

    [SerializeField] MonoBehaviour movementSource;
    private IMovementData m_player;
    [SerializeField] TextMeshProUGUI velocity_Text;

    private void Awake()
    {
        m_player = (IMovementData)movementSource;

        if(m_player == null)
        {
            Debug.LogError("Assigned Movement Source does not implement IMovementData.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        velocity_Text.text = m_player.CurrentVelocity.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        velocity_Text.text = Mathf.Round(m_player.CurrentVelocity.magnitude).ToString();
    }
}
