using UnityEngine;
using TMPro;

public class ScoresOutput : MonoBehaviour {
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    private static ScoresOutput instance;

    void Awake() {
        instance = this;
        score = 0;
        UpdateScoreText();
    }

    public static void AddPoints(int points) {
        score += points;
        Debug.Log("Puntuación del jugador: " + score);
        if (instance != null) {
            instance.UpdateScoreText();
        }
    }

    void UpdateScoreText() {
        if (scoreText != null) {
            scoreText.text = "Puntuación: " + score;
        }
    }
}
