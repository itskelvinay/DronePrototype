using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class DroneCamera : MonoBehaviour
{
    public float mouseSensitivity = 10f;
    public Transform playerBody;

    private Vector2 input;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }

    void Update()
    {
        float mouseX = input.x * mouseSensitivity * Time.deltaTime;
        float mouseY = input.y * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
        playerBody.Rotate(Vector3.left * mouseY);

        //input = Vector2.zero;
    }
}
