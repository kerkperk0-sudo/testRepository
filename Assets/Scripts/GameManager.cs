using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private TMP_Text coinsText;

    private int coins;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        UpdateCoinsUI();
    }

    public void AddCoins(int value)
    {
        coins += value;
        UpdateCoinsUI();
    }

    private void UpdateCoinsUI()
    {
        if (coinsText != null)
        {
            coinsText.text = $"Coins: {coins}";
        }
    }
}
