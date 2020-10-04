using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
  
    public float MaxSpeed = 100F;
    public float Acceleration = 100F;
    public float Deceleration = 10F;
    
    public float MinOffset = -14F;
    public float MaxOffset = 14F;

    public float MaxLean = 25F;
    
    public float CurrentSpeed = 0F;
    private Vector3 newPosition = new Vector3();
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var hAxis = Input.GetAxis("Horizontal");
        
        if (!Mathf.Approximately(hAxis, 0F) && CurrentSpeed > -MaxSpeed && CurrentSpeed < MaxSpeed) 
            CurrentSpeed += Acceleration * hAxis * Time.deltaTime;
        else
        {
            if (CurrentSpeed > Deceleration * Time.deltaTime) 
                CurrentSpeed -= Deceleration * Time.deltaTime;
            else if (CurrentSpeed < -Deceleration * Time.deltaTime)
                CurrentSpeed += Deceleration * Time.deltaTime;
            else
            {
                CurrentSpeed = 0F;
            }
        }
        
        newPosition.x = transform.position.x + CurrentSpeed * Time.deltaTime;

        if (newPosition.x < MinOffset)
        {
            newPosition.x = MinOffset;
            CurrentSpeed = 0F;
        }
        
        if (newPosition.x > MaxOffset)
        {
            newPosition.x = MaxOffset;
            CurrentSpeed = 0F;
        }


        transform.position = newPosition;

        float angle;

        if (Mathf.Approximately(newPosition.x, 0F))
        {
            angle = 0F;
        } 
        else if (newPosition.x > 0)
        {
            angle = (newPosition.x / MaxOffset) * MaxLean;
        }
        else
        {
            angle = (newPosition.x / MinOffset) * -MaxLean;
        }

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
