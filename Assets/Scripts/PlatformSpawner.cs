using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public Transform axle;
    public GameObject goodPlatform;
    public GameObject badPlatform;
    
    private float badSpawnChance = 25f;
    private GameObject platform;
    private float offset = 0.35f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -3; i < 5; i++)
        {
            int platformCount = 0;
            if(Random.Range(0, 2) == 1)
            {
                Instantiate(Random.Range(0, 100) < badSpawnChance ? badPlatform : goodPlatform,
                    axle.transform.position + new Vector3(-offset, 2 * i, offset),
                    Quaternion.Euler(-90, 0, 0),
                    axle.transform
                );
                platformCount++;
            }
            if(Random.Range(0, 2) == 1)
            {
                Instantiate(Random.Range(0, 100) < badSpawnChance ? badPlatform : goodPlatform,
                    axle.transform.position + new Vector3(offset, 2 * i, offset),
                    Quaternion.Euler(-90, 90, 0),
                    axle.transform
                );
                platformCount++;
            }
            if(Random.Range(0, 2) == 1)
            {
                Instantiate(Random.Range(0, 100) < badSpawnChance ? badPlatform : goodPlatform,
                    axle.transform.position + new Vector3(-offset, 2 * i, -offset),
                    Quaternion.Euler(-90, -90, 0),
                    axle.transform
                );
                platformCount++;
            }
            if(platformCount < 3)
            {
                if(Random.Range(0, 2) == 1)
                {
                    Instantiate(Random.Range(0, 100) < badSpawnChance ? badPlatform : goodPlatform,
                        axle.transform.position + new Vector3(offset, 2 * i, -offset),
                        Quaternion.Euler(-90, 180, 0),
                        axle.transform
                    );
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
