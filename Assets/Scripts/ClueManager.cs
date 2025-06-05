using UnityEngine;

public class ClueManager : MonoBehaviour
{
    public static ClueManager Instance;

    public GameObject clueSpherePrefab;
    public Transform[] clueSpawnPoints;
    public string[] clueTexts;

    private int currentClueIndex = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        SpawnNextClue();
    }

    public void SpawnNextClue()
    {
        if (currentClueIndex >= clueTexts.Length || currentClueIndex >= clueSpawnPoints.Length)
            return;

        GameObject sphere = Instantiate(clueSpherePrefab, clueSpawnPoints[currentClueIndex].position, Quaternion.identity);
        ItemPickup pickup = sphere.GetComponent<ItemPickup>();
        pickup.clueText = clueTexts[currentClueIndex];

        currentClueIndex++;
    }
}
