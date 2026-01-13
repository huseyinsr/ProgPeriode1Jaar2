/*using UnityEngine;

public class Elf : EnemyLes5
{
    private Renderer renderer;
    public float timer = 0f;
    private bool isHidden = false;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        speed = 2.5f;
    }

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        timer += Time.deltaTime;

        if (!isHidden && timer >= 3f)
        {
            renderer.enabled = false;
            isHidden = true;
            timer = 0f;
        }
        else if (isHidden && timer >= 1f)
        {
            renderer.enabled = true;
            isHidden = false;
            timer = 0f;
        }
    }
}
*/

