using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject laserPrefab;
    public float cooldownTime = 3f;

    private float cooldownCounter = 0f;

    void Update()
    {
        cooldownCounter += Time.deltaTime;
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldownCounter > cooldownTime)
        {
            GameObject laser = Instantiate(laserPrefab);
            laser.transform.position = transform.position;
            laser.transform.rotation = transform.rotation;
            Destroy(laser, 3f);

            cooldownCounter = 0f;
        }
    }

    public void ImproveFireRate(float improvement)
    {
        cooldownTime -= improvement;
    }
}