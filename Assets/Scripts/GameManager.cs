using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool isGameActive;


    public float spawnRateSecs = 2f;
    private int score = 0;

    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());   
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true); 

    }

    public void RestartGame()
    {
        //restartButton.gameObject.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddToScore(int addScore)
    {
        score += addScore;
        scoreText.text = "Score : " + score;
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            
            yield return new WaitForSeconds(spawnRateSecs);

            Instantiate(targets[Random.Range(0,targets.Count)]);
        }
    }
}
