using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isPause;
    public GameObject pauseMenu;

    public string MainMenu;
    void Start()
    {

        pauseMenu.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Pause");
            if (isPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
     public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPause = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPause = false;
    }

     public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MainMenu);
    }
}
