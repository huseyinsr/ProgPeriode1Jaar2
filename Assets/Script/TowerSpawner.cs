/*using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnTower();
        }
    }

    void SpawnTower()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-5f, 5f),
            -1.6f,
            Random.Range(-5f, 5f)
            );

        GameObject newTower = Instantiate(towerPrefab, randomPosition, Quaternion.identity);
    }

    void SpawnTowerAtClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 spawnPosition = hit.point;
            spawnPosition.y = -1.6f; // Adjust the y-coordinate as needed
            Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
*/