/*using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    List<InventoryItem> inventory = new List<InventoryItem>();

    int guns = 2, meds = 4, keys = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) Toggle("Gun", ref guns);
        if (Input.GetKeyDown(KeyCode.M)) Toggle("Medipack", ref meds);
        if (Input.GetKeyDown(KeyCode.K)) Toggle("Keycard", ref keys);
    }

    void Toggle(string name, ref int world)
    {
        InventoryItem item = inventory.Find(i => i.name == name);

        if (item != null)
        {
            inventory.Remove(item);
            world++;
        }
        else if (world > 0)
        {
            inventory.Add(new InventoryItem(name));
            world--;
        }

        Debug.Log($"World: G={guns} M={meds} K={keys} | Inventory: G={Count("Gun")} M={Count("Medipack")} K={Count("Keycard")}");
    }

    int Count(string name)
    {
        int c = 0;
        foreach (var i in inventory)
            if (i.name == name) c++;
        return c;
    }
}
*/
