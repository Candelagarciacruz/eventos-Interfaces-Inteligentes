using UnityEngine;

public class ShieldCollector : MonoBehaviour {
    public int shieldType;

    void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Player")) {
            return;
        }
        if (shieldType == 1) {
            Debug.Log("Recogido escudo tipo 1 (+5)");
            getReward.AddPoints(5);
        } else if (shieldType == 2) {
            Debug.Log("Recogido escudo tipo 2 (+10)");
            getReward.AddPoints(10);
        }
        Destroy(gameObject);
    }
}
