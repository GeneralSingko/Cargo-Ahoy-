using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipDebugger : MonoBehaviour
{
    public Ship player;
    public SeaManager sea;

    public RectTransform showButton;
    public RectTransform panel;

    public Dictionary<string, TextMeshProUGUI> stats = new Dictionary<string, TextMeshProUGUI>();

    void Start()
    {
        Transform values = transform.GetChild(0).transform.Find("Values").transform;
        for (int i = 0; i < values.childCount; i++)
        {
            stats.Add(values.GetChild(i).name, values.GetChild(i).GetComponent<TextMeshProUGUI>());
        }

    }

    // Update is called once per frame
    void Update()
    {
        stats["Position"].text = $"{player.Position.x.ToString("F2")}, {player.Position.y.ToString("F2")}";
        stats["Velocity"].text = player.Velocity.y.ToString("F2");
        stats["Sailspeed"].text = player.SailSpeed.ToString();
        stats["Health"].text = player.HealthFraction;
        stats["Progress"].text = sea.Progress;
    }

    public void HideDebugPanel()
    {
        panel.gameObject.SetActive(false);
        showButton.gameObject.SetActive(true);
    }

    public void ShowDebugPanel()
    {
        panel.gameObject.SetActive(true);
        showButton.gameObject.SetActive(false);
    }
}
