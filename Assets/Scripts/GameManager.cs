using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public TMP_Text scoreText;
    public GameObject winText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        scoreText.text = "Coins: 0/5";
        winText.SetActive(false);
    }

    public void AddCoin()
    {
        score++;

        scoreText.text = "Coins: " + score + "/5";

        if (score >= 5)
        {
            winText.SetActive(true);
        }
    }
}