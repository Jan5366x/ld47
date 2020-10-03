using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    public float Speed = 10F;
    public float MinOffset = -3F;
    public float MaxOffset = 3F;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var hAxis = Input.GetAxis("Horizontal");

        var translateVector = Vector3.right * (hAxis * Speed * Time.deltaTime);
        var newPosition = transform.position + translateVector;
     
        if(newPosition.x >= MinOffset && newPosition.x <= MaxOffset)
        {
            transform.Translate(translateVector);
        }
    }
}
