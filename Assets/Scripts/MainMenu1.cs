using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void fase2()
    {
        SceneManager.LoadScene("MiniGame2");
    }

}



