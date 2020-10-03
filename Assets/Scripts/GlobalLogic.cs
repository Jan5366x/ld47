using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GlobalLogic : MonoBehaviour
{
    public static int Score = 0;

    public static bool IsAlive = true;

    public float RestartTime = 2F;
    private float timer = 0F;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("escape")) {
            Application.Quit();
        }
        
        if (!IsAlive)
        {
            if (timer >= RestartTime)
            {
                SceneManager.LoadScene( SceneManager.GetActiveScene().name );
                IsAlive = true;
                timer = 0F;
                Score = 0;
            }
            
            timer += Time.deltaTime;
        }
    }
}
