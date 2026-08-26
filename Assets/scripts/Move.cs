using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private float speed = 5;

    public Rigidbody rb;

    void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;
        if (Keyboard.current[Key.W].isPressed) { direction += transform.forward; }

        direction = Vector3.ClampMagnitude(direction, 1f);

        rb.linearVelocity = new Vector3(direction.x * speed, rb.linearVelocity.y, direction.z * speed);
    }
}
