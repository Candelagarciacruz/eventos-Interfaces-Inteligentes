using UnityEngine;

public class SpheresObserve : MonoBehaviour {
    public int type;
    public Transform greenSphereObjective;
    public float speed = 2f;
    
    private Rigidbody rb;
    private Transform objective;
    private bool move = false;

    void Start() {
        rb = GetComponent<Rigidbody>();
        if (type == 1) {
            GetComponent<Renderer>().material.color = Color.red;
        } else if (type == 2) {
            GetComponent<Renderer>().material.color = Color.green;
        }       
    }

    // It runs every time the GameObject becomes active or the script is enabled.
    void OnEnable() {
        CylinderNotifies.onCollision += React;
    }

    // It runs when a script is disabled or the GameObject it's attached to is deactivated.
    void OnDisable() {
        CylinderNotifies.onCollision -= React;
    }

    void React() {
        move = true;
        if (type == 1) {
            objective = greenSphereObjective;
        } else if (type == 2) {
            objective = GameObject.Find("Cylinder").transform;
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
