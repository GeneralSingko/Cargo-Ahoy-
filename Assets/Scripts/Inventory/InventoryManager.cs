using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public ShipInventory shipInventory;

    private void Start()
    {
        shipInventory.PrintInventory();
    }
    public void AddFood(int amount)
    {
        shipInventory.food += amount;
    }
    public void RemoveFood(int amount)
    {
        shipInventory.food -= amount;
    }
    public void AddWater(int amount)
    {
        shipInventory.water += amount;
    }
    public void RemoveWater(int amount)
    {
        shipInventory.water -= amount;
    }
    public void AddCannons(int amount)
    {
        shipInventory.cannons += amount;
    }
    public void RemoveCannons(int amount)
    {
        shipInventory.cannons -= amount;
    }
    public void AddSails(int amount)
    {
        shipInventory.sails += amount;
    }
    public void RemoveSails(int amount)
    {
        shipInventory.sails -= amount;
    }
    public void AddWood(int amount)
    {
        shipInventory.wood += amount;
    }
    public void RemoveWood(int amount)
    {
        shipInventory.wood -= amount;
    }
    public void AddIron(int amount)
    {
        shipInventory.iron += amount;
    }
    public void RemoveIron(int amount)
    {
        shipInventory.iron -= amount;
    }
}