using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, int> items;

    public Inventory()
    {
        items = new Dictionary<string, int>();
    }

    public void AddItem(string item, int quantity)
    {
        if (items.ContainsKey(item))
        {
            items[item] += quantity;
        }
        else
        {
            items.Add(item, quantity);
        }
    }

    public void RemoveItem(string item, int quantity)
    {
        if (items.ContainsKey(item))
        {
            items[item] -= quantity;

            if (items[item] <= 0)
            {
                items.Remove(item);
            }
        }
    }

    public int GetQuantity(string item)
    {
        if (items.ContainsKey(item))
        {
            return items[item];
        }
        else
        {
            return 0;
        }
    }

    public void PrintInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (KeyValuePair<string, int> item in items)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        inventory.AddItem("food", 50);
        inventory.AddItem("water", 100);
        inventory.AddItem("cannons", 10);

        inventory.PrintInventory();

        inventory.RemoveItem("cannons", 5);

        inventory.PrintInventory();

        Console.WriteLine("Quantity of food: " + inventory.GetQuantity("food"));
    }
}