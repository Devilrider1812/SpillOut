
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenPanel()
    {
        if (panel.activeInHierarchy == false)
            panel.SetActive(true);
        else
            panel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
