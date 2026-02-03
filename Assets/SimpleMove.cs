using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 5f;
    public float mouseSensitivity = 2f;
    public bool movementEnabled = false;
    
    private Rigidbody rb;
    private Transform cameraTransform;
    private float verticalRotation = 0f;

    void Start() {
        rb = GetComponent<Rigidbody>();

        cameraTransform = GetComponentInChildren<Camera>().transform;
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        
        if (movementEnabled)
        {
            rb.linearVelocity = new Vector3(move.x * speed, rb.linearVelocity.y, move.z * speed);
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);

        verticalRotation -= mouseY;

        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}