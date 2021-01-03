using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    public TextMeshProUGUI scoreBox;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreBox.text = "Score: 0" + Mathf.Round(Time.timeSinceLevelLoad * 10);        
    }
}
