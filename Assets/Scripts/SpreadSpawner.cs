using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SpreadSpawner : MonoBehaviour
{
    public float Range = 2F;
    public float SpawnSpeed = 10F;
    public float SpawnSpeedReduction = 0.0001F;
    public GameObject SpawnObject;
    public float MinSpawnSpeed = 0.1F;

    private float timer = 0F;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (SpawnSpeed > MinSpawnSpeed)
            SpawnSpeed -= SpawnSpeedReduction * Time.deltaTime;
        
        if (timer >= SpawnSpeed)
        {
            var oldPos = transform.position;
            var position = oldPos;
            position.Set(oldPos.x + Random.Range(-Range, Range), oldPos.y, oldPos.z);
            
            Instantiate(SpawnObject, position, transform.rotation );
            timer = 0F;
        }
    }
}
