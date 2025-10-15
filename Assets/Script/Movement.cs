/*using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 25f;
    private bool usePlayerInput = true;

    private void Update()
    {
        Move();
        if (usePlayerInput)
        {
            Rotate();
        }
    }

    private void Move()
    {
        float moveInput = usePlayerInput ? Input.GetAxis("Vertical") : 1f;
        transform.position = transform.position + transform.forward * moveSpeed * moveInput * Time.deltaTime;
    }

    private void Rotate()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}*/