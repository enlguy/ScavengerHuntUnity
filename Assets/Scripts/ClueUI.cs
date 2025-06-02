using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro support

public class ClueUI : MonoBehaviour
{
    public static ClueUI Instance;

    public GameObject cluePanel;
    public TMP_Text clueText;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        if (cluePanel != null)
        {
            cluePanel.SetActive(false);
            Debug.Log("ClueUI Awake - cluePanel assigned successfully");
        }
        else
        {
            Debug.Log("ClueUI Awake - cluePanel is NULL");
        }
    }

    public void ShowClue(string text)
    {
        Debug.Log("ShowClue called with text: " + text);
        
        if (cluePanel == null)
        {
            Debug.Log("ShowClue - cluePanel is null!");
            return;
        }
        
        if (clueText == null)
        {
            Debug.Log("ShowClue - clueText is null!");
            return;
        }
        
        clueText.text = text;
        cluePanel.SetActive(true);
        Debug.Log("Panel activated successfully");
        Invoke("HideClue", 5f);
    }

    public void HideClue()
    {
        if (cluePanel != null)
        {
            cluePanel.SetActive(false);
        }
    }
}