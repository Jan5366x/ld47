using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class PlayerShotLogic : MonoBehaviour
{
    public float Speed = 5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        var hitLogic = other.gameObject.GetComponent<TargetHealth>();

        if (hitLogic != null)
        {
            hitLogic.Hit();
            Destroy(gameObject);
        }
    }
}
