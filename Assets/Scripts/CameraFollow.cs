using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
   
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 newPosition = transform.position = Player.transform.position + offset;
        transform.position = newPosition;
    }
}
