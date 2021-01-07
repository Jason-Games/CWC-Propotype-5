using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRateSecs = 1f;


    void Start()
    {
        StartCoroutine(SpawnTarget());   
    }

    // Update is called once per frame
    void Update()
    {
        
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
