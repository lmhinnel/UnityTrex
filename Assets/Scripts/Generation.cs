using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public GameObject obs;
    public GameObject tentacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 1f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        obs = Instantiate(tentacle, transform.position, Quaternion.identity);
    }    
}
