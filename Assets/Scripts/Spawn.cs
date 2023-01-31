﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
        public GameObject pipe;
        public float spawnRate = 2;
        private float timer = 0;

        public float heightOffSet = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPipe();
    }
    
    void spawnPipe()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {

            float highestOffSet = transform.position.y + heightOffSet;
            float lowestOffSet = transform.position.y - heightOffSet;

            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(highestOffSet, lowestOffSet), 0), transform.rotation);
            timer = 0;
        }
    }
}
