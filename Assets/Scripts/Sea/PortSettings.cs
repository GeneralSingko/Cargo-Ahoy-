using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortSettings : MonoBehaviour
{
    public ShipData playerData;
    public SeaData seaData;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RepairShip()
    {
        playerData.health = playerData.maxHealth;
    }

    public void Sail()
    {
        seaData.distanceToNextPort = 1000f * Random.value;
        SceneManager.LoadScene("Sailing");
    }
}
