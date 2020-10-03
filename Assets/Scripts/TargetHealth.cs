using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class TargetHealth : MonoBehaviour, IHit
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
        if (GlobalLogic.IsAlive)
            GlobalLogic.Score += 5;
        
        Instantiate(exploEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public bool IsPlayer()
    {
        return false;
    }

    public bool IsEnemy()
    {
        return true;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        var hitLogic = other.gameObject.GetComponent<PlayerHealth>();

        if (hitLogic != null)
        {
            hitLogic.Hit();
            Destroy(gameObject);
        }
    }
}
