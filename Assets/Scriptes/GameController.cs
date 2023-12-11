using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;
    int m_core;
    bool m_isGameOver;

    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score: " + m_core);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if(m_isGameOver)
        {
            m_spawnTime = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }

        if (m_spawnTime <= 0)
        {
            SpawnBall();
            m_spawnTime = spawnTime;
        }
    }
    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range((float)-7.5, (float)7.5), (float)6.5);
        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }
    public void Replay()
    {
        m_core = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + m_core);
        m_ui.ShowGameOverPanel(false);
    }
    public void SetCore(int value)
    {
        m_core = value;
    }
    public int GetCore()
    {
        return m_core;
    }
    public void IncrementScore()
    {
        m_core++;
        m_ui.SetScoreText("Score: " + m_core);
    }
    public bool IsGameOver()
    {
        return m_isGameOver;
    }
    public void SetGameoverState(bool state)
    {
        m_isGameOver = state;
    }
}
