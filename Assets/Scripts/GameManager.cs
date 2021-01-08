using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    

    private float spawnRateSecs = 1f;
    private int score = 0;

    void Start()
    {
        StartCoroutine(SpawnTarget());   
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToScore(int addScore)
    {
        score += addScore;
        scoreText.text = "Score : " + score;
    }

    IEnumerator SpawnTarget()
    {
        while(true)
        {
            
            yield return new WaitForSeconds(spawnRateSecs);

            Instantiate(targets[Random.Range(0,targets.Count)]);
        }
    }
}
