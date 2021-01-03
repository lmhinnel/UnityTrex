using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeScrolling : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.timeSinceLevelLoad * speed) % 1, 0f);
    }
}
