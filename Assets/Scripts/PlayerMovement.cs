using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed = 2.0f;
    private float playerGravity = -9.81f;

    Vector3 velocity;

    void Start() { }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * playerSpeed * Time.deltaTime);

        velocity.y += playerGravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
