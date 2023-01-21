using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Stats : MonoBehaviour
{
    public ShipData playerData;
    public Dictionary<string, TextMeshProUGUI> stats = new Dictionary<string, TextMeshProUGUI>();

    void Start()
    {
        Transform values = transform.Find("Values").transform;
        for (int i=0; i < values.childCount; i++)
        {
            stats.Add(values.GetChild(i).name, values.GetChild(i).GetComponent<TextMeshProUGUI>());
        }

    }

    // Update is called once per frame
    void Update()
    {
        stats["Health"].text = $"{playerData.health} / {playerData.maxHealth}";
    }

}
