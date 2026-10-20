using UnityEngine;

public class CubeNotifies : MonoBehaviour {
    public delegate void Message();
    public static event Message onType1;
    public static event Message onType2;

    // It runs when an object with a physical collider collides with another object.
    void OnCollisionEnter(Collision collision) {
        HumanoidsObserve humanoid = collision.gameObject.GetComponent<HumanoidsObserve>();

        if (humanoid == null) {
            return;
        }
        // If the cube collides with a type 1 humanoid, invokes onType1.
        if (humanoid.type == 1) {
            onType1?.Invoke();
        } else if (humanoid.type == 2) {
            onType2?.Invoke();
        }
    }
}
