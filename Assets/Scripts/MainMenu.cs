using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Game has quit");
        Application.Quit();
        
    }
}



