using UnityEngine;

public class FootmanNotifies : MonoBehaviour {
    public delegate void Message();
    public static event Message onCollision;
    
    // It runs when an object with a physical collider collides with another object.
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "FreeLichPolyart") {
            Debug.Log("El humanoide footman ha chocado con el humanoide lich");
            // Send the notice to all subscribed spheres.
            // ?. avoids attempting to invoke the event if there is no subscribed sphere.
            onCollision?.Invoke();
        }
    }
}
