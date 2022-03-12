using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public string Level1Sence;
    public string ScoreboardSence;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Level1Sence);
    }

    public void Scoreboard()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
