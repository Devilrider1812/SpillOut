using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playerlvl : MonoBehaviour
{
    public static PlayerMovement Instance;
    
    GameObject gameover;
    GameObject turn;
    private float minspeed = 3f,
        maxspeed = 7f,
        speedMod = 0.01f;

    private bool isrotate = true;
    private Touch touch;
    [SerializeField]private  Slider slider;
    public GameObject[] Obstacles;

    public GameObject refill;

  
    public GameObject GOpanel;
    public GameObject dbpanel;

    public AudioClip pwerup, obst;

    bool ispaused = false;
    bool  iscollect = false;

    private float sliderValue;

    void Start()
    {
        GOpanel.SetActive(false);
        dbpanel.SetActive(false);
        slider.onValueChanged.AddListener(delegate { SpeedSlider(); });
        gameover = GameObject.FindGameObjectWithTag("GameOver");
    
    }
 public   void Update()
    {
        if (ispaused == false)
        {
            transform.position += new Vector3(0, 0, 1f) * Time.deltaTime * (sliderValue + minspeed);
            refill.transform.localScale -= new Vector3(0, 0.001f, 0);
            Gameplay();
        }

        if (refill.transform.localScale.y  < 1f )
        {
            iscollect = true;
        }
       else 
        {
            iscollect = false;
        }

        if (dbpanel.activeSelf)
        {
            ispaused = true;
        }
        else
        {
            ispaused = false;
        }
    }
    public void SpeedSlider()
    {
        sliderValue = slider.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (iscollect)
        {
            if (other.gameObject.tag == "Refills")
            {
                Destroy(other.gameObject);
                refill.transform.localScale += new Vector3(0, 0.5f, 0);
                SoundController.soundctrl.playClip(pwerup);
            }
        }

        if (other.gameObject.tag == "Obstacles")
        {
            Destroy(other.gameObject);
            refill.transform.localScale -= new Vector3(0, 0.05f, 0);
            SoundController.soundctrl.playClip(obst);
        }

        if (other.gameObject.tag == "GameOver")
        {
            GOpanel.SetActive(true);
        }

        if (other.gameObject.tag == "levelpass")
        {
            SceneManager.LoadScene("Level2");
        }
    }

    public void OpenPanel()
    {
        if (dbpanel.activeInHierarchy == false)
            dbpanel.SetActive(true);
        else
            dbpanel.SetActive(false);
        ispaused = true;
    }

    void Gameplay()
    {
        
        if (refill.transform.localScale.y < 0.1)
        {
            GOpanel.SetActive(true);
          //  Destroy(refill, 0);
          //  Destroy(this.gameObject);

        }

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                Debug.Log("Move");
              
                 transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedMod, transform.position.y, transform.position.z);
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
