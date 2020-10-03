﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text textObj;
    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textObj.text = GlobalLogic.Score.ToString();
    }
}
