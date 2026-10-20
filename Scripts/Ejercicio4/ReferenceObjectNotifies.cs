using UnityEngine;

public class ReferenceObjectNotifies : MonoBehaviour {
    public delegate void Message();
    public static event Message onType1;
    public static event Message onType2;

    void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Cube")) {
            return;
        }
        onType1?.Invoke();
        onType2?.Invoke();
    }
}
