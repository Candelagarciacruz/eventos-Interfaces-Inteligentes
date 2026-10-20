using UnityEngine;

public class HumanoidsObserve : MonoBehaviour {
    public int type;
    public Transform shieldType1Objective;
    public float speed = 2f;
    
    private Rigidbody rb;
    private Transform objective;
    private bool move = false;

    void Start() {
        rb = GetComponent<Rigidbody>();  
    }

    // It runs every time the GameObject becomes active or the script is enabled.
    void OnEnable() {
        CubeNotifies.onType1 += ReactToType1;
        CubeNotifies.onType2 += ReactToType2;
    }

    // It runs when a script is disabled or the GameObject it's attached to is deactivated.
    void OnDisable() {
        CubeNotifies.onType1 -= ReactToType1;
        CubeNotifies.onType2 -= ReactToType2;
    }

    void ReactToType1() {
        if (type == 2) {
            GameObject[] shields = GameObject.FindGameObjectsWithTag("EscudoT2");
            if (shields.Length > 0) {
                objective = shields[Random.Range(0, shields.Length)].transform;
                move = true;
            }
        }
    }

    void ReactToType2() {
        if (type == 1) {
            objective = shieldType1Objective;
            move = (objective != null);
        }
    }

    // It runs before each physics update.
    void FixedUpdate() {
        if (move && objective != null && rb != null) {
            Vector3 direction = (objective.position - rb.position).normalized;
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        }
    }

    // It runs when an object with a physical collider collides with another object.
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("EscudoT1") || collision.gameObject.CompareTag("EscudoT2")) {
            Renderer[] allRds = collision.gameObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer actualRd in allRds) {
                foreach (Material mat in actualRd.materials) {
                    if (mat.HasProperty("_Tint")) {
                        mat.SetColor("_Tint", Color.black);
                    }
                }
            }
            move = false;
        }
    }
}
