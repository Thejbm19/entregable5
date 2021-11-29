using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    private float startTime = 0.5f;
    private float repeatRate = 5f;
    private int Number = 50;

    // Start is called before the first frame update
    void Start()
    {
        //invoca la funcion cada 5 segundos
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }

    // funcion que spawnea los obstaculos
    public void SpawnObstacle()
    {

        randomY = Random.Range(-10f, 10f); // numero aleatorio entre -10 y 10
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); //funcion para instanciar los obstaculos
        spawnPos = new Vector3(0, randomY, spawnPos.z + Number); //posicion de spawneo de los obstaculos




    }
}
