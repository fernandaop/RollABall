using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int finalScore = 0;  // Armazena a pontuação final.

    void Awake()
    {
        // Garante que o GameManager persista entre cenas.
        DontDestroyOnLoad(gameObject);
    }
}
