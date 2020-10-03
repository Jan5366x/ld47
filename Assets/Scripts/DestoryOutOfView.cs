using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfView : MonoBehaviour
{
    public float Deep = -20F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < Deep)
            Destroy(gameObject);
    }
}
