using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ClueUI clueUI;
    public string clueText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with item.");  // Debug line
            clueUI.ShowClue(clueText);
            gameObject.SetActive(false);
        }
    }
}
