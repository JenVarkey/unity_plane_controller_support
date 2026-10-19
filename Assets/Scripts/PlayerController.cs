using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 100f;
    public InputAction MoveAction;
    public Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }

   
    // Update is called once per frame
    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
