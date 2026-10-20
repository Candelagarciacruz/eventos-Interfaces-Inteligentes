using UnityEngine;

public class humanoidesObserve : MonoBehaviour {
    public int type;
    public Transform shieldType1Objective;
    public Transform orientationTarget;
    public float rotationSpeed = 180f;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();  
    }

    // It runs every time the GameObject becomes active or the script is enabled.
    void OnEnable() {
        ReferenceObjectNotifies.onType1 += ReactToType1;
        ReferenceObjectNotifies.onType2 += ReactToType2;
    }

    // It runs when a script is disabled or the GameObject it's attached to is deactivated.
    void OnDisable() {
        ReferenceObjectNotifies.onType1 -= ReactToType1;
        ReferenceObjectNotifies.onType2 -= ReactToType2;
    }


    // Type 1 -> Teleport to the assigned shield.
    void ReactToType1() {
        if (type == 1) {
            if (shieldType1Objective != null) {
                rb.position = shieldType1Objective.position;
            }
        }
    }

    // Group 2: Look towards the orientation object.
    void ReactToType2() {
        if (type == 2) {
            if (orientationTarget != null) {
                Vector3 direction = orientationTarget.position - rb.position;
                direction.y = 0f;
                if (direction.sqrMagnitude > 0.001f) {
                    rb.rotation = Quaternion.LookRotation(direction);
                }
            }
        }
    }
}
