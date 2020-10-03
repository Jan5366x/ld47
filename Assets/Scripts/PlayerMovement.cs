using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int MaxMovement = 2;
    public float Speed = 10F;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var hAxis = Input.GetAxis("Horizontal");

      
        transform.Translate(Vector3.right * (hAxis * Speed * Time.deltaTime));
    }
}
