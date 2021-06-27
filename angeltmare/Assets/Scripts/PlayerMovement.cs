using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody2D rb;

    [Header("Movement Variable")]
    [SerializeField] private float moveSpeed = 5f;
    private Vector2 moveInput;

    [Header("Camera Movement")]
    private Vector2 mouseInput;
    [SerializeField] private float mouseSensitivity = 1f;
    [SerializeField] private Transform viewCam;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        Movement();
        CameraMovement();
    }

    private void Movement(){
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        Vector3 moveHorizontal = transform.up * -moveInput.x;
        Vector3 moveVertical   = transform.right * moveInput.y;

        rb.velocity = (moveHorizontal + moveVertical) * moveSpeed; 
    }

    private void CameraMovement(){
        float maxAngle = 160;
        float minAngle = 10;

        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input
        .GetAxisRaw("Mouse Y")) * mouseSensitivity * Time.deltaTime;

        Vector3 rotAmount = viewCam.transform.localRotation.eulerAngles + new Vector3(0f,mouseInput.y,0f);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 
                             transform.rotation.y, transform.rotation.eulerAngles.z - mouseInput.x);

        viewCam.transform.localRotation = Quaternion.Euler(rotAmount.x, Mathf.Clamp(rotAmount.y,minAngle,maxAngle),rotAmount.z);
    }
}
