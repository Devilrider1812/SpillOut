using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject powerup1;
    bool isactive = false;
    [SerializeField] private float timer = 30f;

    public GameObject refill;
    void Start()
    {
        powerup1 = GameObject.FindGameObjectWithTag("Powerup1");  //powernip
        // playerMove = GameObject.FindGameObjectsWithTag<PlayerMovement>();
        // powerup1.SetActive(true);
    }

    void Update()
    {
        Debug.Log(" Timer " + timer);

        if (isactive)
        {
            refill.transform.localScale += new Vector3(0, 0.001f, 0);

            timer -= 0.1f;

            if (timer < 0)
            {
                refill.transform.localScale -= new Vector3(0, 0.001f, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isactive = true;
            Destroy(this.gameObject);
        }
    }
}







