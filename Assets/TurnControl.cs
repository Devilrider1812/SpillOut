using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnControl : MonoBehaviour
{
    public GameObject target;
    private float SPEED=0.1f;
    GameObject turn;
    void Start()
    {
       turn = GameObject.FindGameObjectWithTag("Turn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            target. transform.Rotate(Vector3.right * SPEED * Time.deltaTime);
            Destroy(this.gameObject);
        }
    }
}
