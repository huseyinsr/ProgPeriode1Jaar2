/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSystem : MonoBehaviour
{
    public Image itemImageHolder;
    private List<Color> items = new List<Color>();
    private int activeItemIndex = -1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            PickUpItem(other.gameObject);
        }
    }

    void PickUpItem(GameObject item)
    {
        Color color = item.gameObject.GetComponent<Renderer>().material.color;
        Destroy(item);
        items.Add(color);
        activeItemIndex = items.Count - 1;
        itemImageHolder.color = items[activeItemIndex];
        itemImageHolder.enabled = true;
    }

    void CycleItems()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (items.Count > 0)
            {
                if (activeItemIndex < items.Count - 1)
                {
                    activeItemIndex++;
                }
                else
                {
                    activeItemIndex = 0;
                }
                itemImageHolder.color = items[activeItemIndex];
            }
            else
            {
                itemImageHolder.color = Color.white;
                activeItemIndex = -1;
                itemImageHolder.enabled = false;
            }
        }
    }

    public void UseItem()
    {
        if (Input.GetKeyDown(KeyCode.E) && items.Count > 0 && activeItemIndex != -1)
        {
            Movement movement = GetComponent<Movement>();
            Shooting shooting = GetComponent<Shooting>();
            UIManager uiManager = FindObjectOfType<UIManager>();

            if (items[activeItemIndex] == Color.blue)
            {
                uiManager.ShowMessage(" + Move Speed");
                movement.moveSpeed += 5;
            }
            else if (items[activeItemIndex] == Color.red)
            {
                uiManager.ShowMessage(" + Fire Rate");
                shooting.ImproveFireRate(0.1f);
            }
            else if (items[activeItemIndex] == Color.green)
            {
                uiManager.ShowMessage(" + Rotation Speed");
                movement.rotationSpeed += 10;
            }

            items.RemoveAt(activeItemIndex);
            if (activeItemIndex > 0)
            {
                activeItemIndex--;
                itemImageHolder.color = items[activeItemIndex];
            }
            else if (items.Count == 0)
            {
                itemImageHolder.color = Color.white;
                activeItemIndex = -1;
                itemImageHolder.enabled = false;
            }
        }
    }

    void Update()
    {
        CycleItems();
        UseItem();
    }
}*/