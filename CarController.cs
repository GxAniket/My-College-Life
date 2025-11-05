using UnityEngine;

public class CarControllerPhysics : MonoBehaviour
{
    public float speed = 1000f;
    public float turnSpeed = 15f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        // Forward motion
        rb.AddRelativeForce(Vector3.forward * move * speed * Time.fixedDeltaTime);

        // Turning
        transform.Rotate(0, turn * turnSpeed * Time.fixedDeltaTime, 0);
    }
}
