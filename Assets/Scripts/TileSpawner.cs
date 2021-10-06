using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextspawnPoint;
    
    public int tileCount;
    void Start()
    {
        for (int i = 0; i < tileCount; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void SpawnTile()
    {
       GameObject temp = Instantiate(groundTile, nextspawnPoint, Quaternion.identity);
        nextspawnPoint = temp.transform.GetChild(1).transform.position;

    }
}
