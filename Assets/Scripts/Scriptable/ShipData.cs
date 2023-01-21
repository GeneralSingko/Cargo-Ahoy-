using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Assets/Scriptable Objects", menuName = "Ship Data")]
public class ShipData : ScriptableObject
{
    public float health;
    public float maxHealth;

    public void SetHealth(float health)
    {
        this.maxHealth = health;
        this.health = maxHealth;
    }
}
