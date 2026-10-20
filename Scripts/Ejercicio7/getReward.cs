using UnityEngine;
using TMPro;

public class getReward : MonoBehaviour {
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI rewardText;
    private static getReward instance;
    private int nextReward = 100;

    void Awake() {
        instance = this;
        score = 0;
        nextReward = 100;
        UpdateScoreText();
        if (rewardText != null) {
            rewardText.text = "";
        }
    }

    public static void AddPoints(int points) {
        score += points;
        Debug.Log("Puntuación del jugador: " + score);
        if (instance != null) {
            instance.UpdateScoreText();
            instance.CheckReward();
        }
    }

    void UpdateScoreText() {
        if (scoreText != null) {
            scoreText.text = "Puntuación: " + score;
        }
    }

    void CheckReward() {
        while (score >= nextReward) {
            string message = "¡Recompensa obtenida al llegar a "
                + nextReward + " puntos!";
            Debug.Log(message);

            if (rewardText != null) {
                rewardText.text = message;
            }
            nextReward += 100;
        }
    }
}
