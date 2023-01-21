using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaManager : MonoBehaviour
{
    public Ship player;
    public SeaData seaData;

    public RectTransform deathScreenPanel;
    
    private float progress;
    private float targetDistance;
    private float timeToSpawnFlotsam;
    private float timeSinceLastSpawn;


    void Start()
    {
        SetTarget(seaData.distanceToNextPort);
    }

    private void FixedUpdate()
    {
        if (!player.IsAlive) EndGame();

        progress += player.SailSpeed * Time.fixedDeltaTime;

        if (IsTargetReached) EnterPort();

        //Countdown to spawn another flotsam
        if (progress < targetDistance * (3 / 4f) && timeSinceLastSpawn > 0) timeSinceLastSpawn -= Time.fixedDeltaTime;
        else
        {
            SpawnFlotsam();
            float m = 1 - ProgressFraction;
            float p = 1 - (1 + 1) * ProgressFraction;
            timeToSpawnFlotsam = m * 10 + p * 0.5f;
            timeSinceLastSpawn = timeToSpawnFlotsam;
        }

    }

    private void SpawnFlotsam()
    {
        GameObject a = FlotsamPool.pool.GetFlotsam();
        if (a != null) a.GetComponent<Flotsam>().Spawn();
    }

    public void EnterPort()
    {
        player.SaveData();
        SceneManager.LoadScene("Port");
    }

    public void EndGame()
    {
        player.Die();
        deathScreenPanel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Sailing");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Title");
        Time.timeScale = 1f;
    }


    public void SetTarget(float newDistance)
    {
        progress = 0f;
        targetDistance = newDistance;
        timeSinceLastSpawn = 0f;
        timeToSpawnFlotsam = 10;
    }

    public float GetSpeed() { return player.SailSpeed; }

    public bool IsTargetReached { get { return ProgressFraction >= 1f; } }

    public float ProgressFraction { get { return progress / targetDistance; } }

    public string Progress { get { return $"{progress.ToString("F2")} / {targetDistance.ToString("F2")}"; } }

    public bool IsFinished { get { return ProgressFraction >= 1f; } }

}
