using UnityEngine;
using UnityEngine.InputSystem;

public class DroneMovement : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 input;
    private float vertical;

    public void OnHorizontalMove(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }

    public void OnVerticalMove(InputAction.CallbackContext context)
    {
        vertical = context.ReadValue<float>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(input.x, -input.y, vertical);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
