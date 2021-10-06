using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps2 : MonoBehaviour
{
    private GameObject powerup2;
    public GameObject obstacles;
    bool isdamage = false;
    [SerializeField] private float timer = 20f;

    // Start is called before the first frame update
    void Start()
    {
        powerup2 = GameObject.FindGameObjectWithTag("Powerup2");
    }

    // Update is called once per frame
    void Update()
    {
        if (isdamage)
        {
            //obstacles.GetComponent<Collider>().enabled = false;

            timer -= 0.1f;

            if (timer < 0)
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    PlayerMovement.Instance.Obstacles[i].SetActive(false);
                //}
               // obstacles.GetComponent<Collider>().enabled = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isdamage = true;
            Destroy(this.gameObject);
        }
    }
}

