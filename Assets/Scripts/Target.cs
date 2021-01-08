using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    Rigidbody body;
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem explosion;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();


        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();


        body.AddForce(GetRandomForce(), ForceMode.Impulse);
        body.AddTorque(GetRandomTorque(), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4, 4), -2);
    }

    Vector3 GetRandomForce()
    {
        return Vector3.up * Random.Range(12, 20);
    }

    Vector3 GetRandomTorque()
    {
        return new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(explosion, transform.position, explosion.transform.rotation);
        gameManager.AddToScore(pointValue);
    } 

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
