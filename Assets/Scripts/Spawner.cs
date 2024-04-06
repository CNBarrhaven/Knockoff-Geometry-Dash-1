using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ChallengeObj;
    public float spawnDelay = 1f;
    public float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, - 3.95f, 0);
    }
    void InstantiateObjects()
    {
        //Instantiate(ChallengeObj, transform.position, transform.rotation);
    }
}
