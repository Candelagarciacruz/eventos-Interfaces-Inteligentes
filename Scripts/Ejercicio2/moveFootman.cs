using UnityEngine;

public class moveFootman : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    // It happens before each physics update.
    void FixedUpdate() {
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        Vector3 newPosition = rb.position + movement * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
