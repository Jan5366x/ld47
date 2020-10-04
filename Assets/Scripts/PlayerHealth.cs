using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHit
{
    public GameObject exploEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Hit()
    {
        GlobalLogic.IsAlive = false;
        Instantiate(exploEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public bool IsPlayer()
    {
        return true;
    }

    public bool IsEnemy()
    {
        return false;
    }
}
