using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_pelotitas : MonoBehaviour
{
    public GameObject spawner;
    public GameObject pelotita;
    public Vector3 offset;

    public float timerBase = 0.75f;
    float timer;

    void Start()
    {
        timer = timerBase;
        offset = spawner.transform.position;
    }

    private void FixedUpdate()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    void Update()
    {
        if (timer <= 0)
        {
            GameObject ball;
            ball = Instantiate(pelotita, offset, Quaternion.identity);
            Rigidbody PelotitaRB = ball.GetComponent<Rigidbody>();
            timer = timerBase;


        }

        
    }
}
