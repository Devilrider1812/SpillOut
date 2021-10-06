using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    private float moveR;
    private float moveL;
    private float maxspeed = 2f;
    void Start()
    {
        transform.Translate(0f, 0f, -maxspeed * Time.deltaTime);
        moveR = 1.80f;
        moveL = moveR;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log(touch.position);
                if (touch.position.x > Screen.width / 2 && transform.position.x < 1.86f)
                    transform.position = new Vector2(transform.position.x + 1.86f, transform.position.y);

                if (touch.position.x < Screen.width / 2 && transform.position.x > -1.86f)
                    transform.position = new Vector2(transform.position.x - 1.86f, transform.position.y);

            }
        }
    }   // Start is called before the first frame update
}
