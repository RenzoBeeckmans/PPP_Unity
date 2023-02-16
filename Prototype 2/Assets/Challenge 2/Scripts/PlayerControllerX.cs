using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeBetweenDogs = 1.5f;
    private float lastDogSpawn;

    void Start()
    {
        lastDogSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastDogSpawn+timeBetweenDogs)
        {
            lastDogSpawn = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
