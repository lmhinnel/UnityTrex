using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Generation : MonoBehaviour
{
    public float timePrev;
    public GameObject tentacle;
    float timer;
    float minTimeRange, maxTimeRange;
    
    // Start is called before the first frame update
    void Start()
    {
        timePrev = UnityEngine.Random.Range(0f, 1f);
        timer = 0;
        minTimeRange = 2f; 
        maxTimeRange = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timePrev)
        {
            GameObject newTentacle = Instantiate(tentacle, transform.position, Quaternion.identity);
            Destroy(newTentacle, 10);
            timer = 0;
            timePrev = UnityEngine.Random.Range(minTimeRange, maxTimeRange);
        }

        timer += Time.deltaTime;
    } 
}
