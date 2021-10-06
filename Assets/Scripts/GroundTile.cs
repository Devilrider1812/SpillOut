using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    TileSpawner tilespawner;

    public GameObject Obstacles;
    public GameObject Refills;
    void Start()
    {
        tilespawner = GameObject.FindObjectOfType<TileSpawner>();
        ObstalesSpawner();
        RefillSpawner();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        tilespawner.SpawnTile();
        Destroy(gameObject, 5f);
    }

    void ObstalesSpawner()
    {
        int SpawnIndex = Random.Range(2, 4);
        Transform SpawnPoint = transform.GetChild(SpawnIndex).transform;
        Instantiate(Obstacles, SpawnPoint.position, Quaternion.identity);
    }

    void RefillSpawner()
    {
        int SpawnIndex = Random.Range(2, 5);
        Transform SpawnPoint = transform.GetChild(SpawnIndex).transform;
        Instantiate(Refills, SpawnPoint.position, Quaternion.identity);
    }
}
