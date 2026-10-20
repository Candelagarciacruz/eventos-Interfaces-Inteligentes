using UnityEngine;

public class ScoresAccumulator : MonoBehaviour {
    public static int score = 0;

    void Awake() {
        score = 0;
    }

    public static void AddPoints(int points) {
        score += points;
        Debug.Log("Puntuación del jugador: " + score);
    }
}
