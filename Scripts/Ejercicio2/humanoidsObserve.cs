using UnityEngine;

public class humanoidsObserve : MonoBehaviour {
    public int type;
    public Transform LichObjective;
    public float speed = 2f;
    
    private Rigidbody rb;
    private Transform objective;
    private bool move = false;

    void Start() {
        rb = GetComponent<Rigidbody>();  
    }

    // It runs every time the GameObject becomes active or the script is enabled.
    void OnEnable() {
        FootmanNotifies.onCollision += React;
    }

    // It runs when a script is disabled or the GameObject it's attached to is deactivated.
    void OnDisable() {
        FootmanNotifies.onCollision -= React;
    }

    void React() {
        move = true;
        if (type == 1) {
            objective = LichObjective;
        } else if (type == 2) {
            objective = GameObject.Find("FootmanHP").transform;
        }
    }

    // It runs before each physics update.
    void FixedUpdate() {
        if (move && objective != null) {
            Vector3 direction = (objective.position - rb.position).normalized;
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        }
    }
}
