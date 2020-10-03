using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponScript : MonoBehaviour
{
    public float FireRate = 2F;
    public GameObject ShotObj;

    private float timer = 0F;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= FireRate && Input.GetButton("Fire1"))
        {
            timer = 0F;
            Instantiate(ShotObj, transform.position, transform.rotation);
        }

        timer += Time.deltaTime;
    }
}
