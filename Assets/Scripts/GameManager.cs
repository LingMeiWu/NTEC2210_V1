using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject carPrefab;
    public Transform[] carSpawnPoints;

    
    // Start is called before the first frame update
    void Start()
    {
       SpawnCar();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCar();
        }
        
    }

    void SpawnCar()
    {
        int index = Random.Range(0, carSpawnPoints.Length);
        Vector3 spawnPos = carSpawnPoints[index].position;

        GameObject car = Instantiate(carPrefab, spawnPos, Quaternion.identity);
        car.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        int dirModifier = (index > 2) ? -1 : 1;

        car.GetComponent<AutoMovement>().speed = Random.Range(3.0f, 6.0f) * dirModifier;

        Debug.Log(Screen.width);

    }


}
