using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public ShipData player;
    public SeaData sea;

    public void StartGame()
    {
        player.SetHealth(100);
        sea.distanceToNextPort = 100f;
        SceneManager.LoadScene("Sailing");
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }
}
