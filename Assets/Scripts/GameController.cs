using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text scoreText;
    int score = 0;
    public GameObject[] shapePrefabs;
    public float spawnDelay = 2;
    public float spawnTime = 3;

    public void Start()
    {
        print("game started");
        gameOverPanel.SetActive(false);
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Vector3 randomspawn = new Vector3(7.29f, -3.95f, 10f);
        //int randomInt = 4;
        Instantiate(shapePrefabs[randomInt], randomspawn, Quaternion.identity);
    }
    public void GameOver()
    {
        
        scoreText.gameObject.SetActive(false);
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
