using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LogicScripts : MonoBehaviour
{

    public int playerScore;
    public TMP_Text scoreText;

    [ContextMenu("increase score")]
    public void addScore(){
        playerScore += 1;
        scoreText.text = playerScore.ToString();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
