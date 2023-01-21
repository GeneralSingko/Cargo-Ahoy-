using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInventory : ScriptableObject
{
    public int food;
    public int water;
    public int cannons;
    public int sails;
    public int wood;
    public int iron;

    public void PrintInventory()
    {
        Debug.Log("Inventory:");
        Debug.Log("Food: " + food);
        Debug.Log("Water: " + water);
        Debug.Log("Cannons: " + cannons);
        Debug.Log("Sails: " + sails);
        Debug.Log("Wood: " + wood);
        Debug.Log("Iron: " + iron);
    }
}
