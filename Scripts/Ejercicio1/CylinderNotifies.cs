using UnityEngine;

public class CylinderNotifies : MonoBehaviour {
    public delegate void Message();
    public static event Message onCollision;
    
    // It runs when an object with a physical collider collides with another object.
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Cube") {
            Debug.Log("El cilindro ha chocado con el cubo");
            // Send the notice to all subscribed spheres.
            // ?. avoids attempting to invoke the event if there is no subscribed sphere.
            onCollision?.Invoke();
        }
    }
}
