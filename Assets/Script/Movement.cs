using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 25f;
    public bool usePlayerInput = true;

    void Update()
    {
        Move();
        if (usePlayerInput)
        {
            Rotate();
        }
    }

    void Move()
    {
        float moveInput = usePlayerInput ? Input.GetAxis("Vertical") : 1f;
        transform.position = transform.position + transform.forward * moveSpeed * moveInput * Time.deltaTime;
    }

    void Rotate()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}