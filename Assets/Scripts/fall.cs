using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    private PlayerController2 playController;
    // Start is called before the first frame update
    void Start()
    {
        // Localiza o PlayController no jogo (pode estar associado ao jogador ou a um outro objeto)
        playController = GameObject.FindObjectOfType<PlayerController2>();
    }

    // Detecta quando a bola entra no trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FallZone"))
        {
            // Chama a função Final() do PlayController
            if (playController != null)
            {
                playController.Final();
            }
            else
            {
                Debug.LogError("PlayController não foi encontrado!");
            }
        }
    }
}

