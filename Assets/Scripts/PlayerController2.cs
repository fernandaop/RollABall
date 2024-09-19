using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody rb; // Rigidbody do jogador.
    private int count; // Contador de objetos coletados.
    private float movementX;
    private float movementY;

    public float speed = 0; // Velocidade do jogador.

    //texts
    public TextMeshProUGUI countText; // Texto da contagem.
    public TextMeshProUGUI winTextObject; // Texto de vitória.
    public TextMeshProUGUI tl_txt; // Texto do tempo atual.
    public TextMeshProUGUI FinalTime; // Texto do tempo final.
    public TextMeshProUGUI FinalCount; // Texto da pontuação final.
    public TextMeshProUGUI livesText; // Texto para mostrar a quantidade de vidas restantes.
    public TextMeshProUGUI fase2Text; // Texto para mostrar a quantidade de vidas restantes.
    public TextMeshProUGUI aviso;
    
    //panels
    public GameObject fase2Panel;
    public GameObject gameOverPanel;

    //botoes reset e quit
    public GameObject quitButton;
    public GameObject fase2Button;

    private float timeLevel; // Tempo do nível.
    private int lives = 3; // Número inicial de vidas.
    public static bool StopTime; // Flag para parar o tempo.
    
    private float lastCollisionTime = 0f; // Tempo da última colisão.
    private float collisionCooldown = 1f; // Intervalo de 1 segundo entre colisões.

    // Start is called before the first frame update.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameOverPanel.SetActive(false);
        fase2Panel.SetActive(false);
        count = 0;
        timeLevel = 0f; 
        StopTime = false; 
        countText.text = "Pontos: 0";
        winTextObject.text = "";
        FinalTime.text = "";
        FinalCount.text = "";
        tl_txt.text = "Tempo: 0s";
        livesText.text = lives + "/3"; 
        fase2Text.text = "";
        aviso.text = "";
        quitButton.SetActive(false);
        fase2Button.SetActive(false);
        SetCountText();
        StopTime = false;
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);

        if (!StopTime)
        {
            timeLevel += Time.deltaTime;
            tl_txt.text = "Tempo: " + timeLevel.ToString("0") + "s";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            // Verificar se o tempo desde a última colisão é maior que o cooldown
            if (Time.time - lastCollisionTime > collisionCooldown)
            {
                lives = lives - 1;
                lastCollisionTime = Time.time; // Atualizar o tempo da última colisão
                UpdateLivesText();
                StartCoroutine(BlinkRed());

                if (lives <= 0)
                {
                    winTextObject.text = "Voce Perdeu!";
                    StopTime = true;
                    Final();
                }
            }
        }
    }

    IEnumerator BlinkRed()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color originalColor = renderer.material.color;

        // Alterar para vermelho
        renderer.material.color = Color.red;

        // Espera de 0.5 segundos
        yield return new WaitForSeconds(0.2f);

        // Voltar para a cor original
        renderer.material.color = originalColor;
    }

    void SetCountText()
    {
        countText.text = "Pontos: " + count.ToString();
        if (count >= 12)
        {
            StopTime = true;
            fase2Button.SetActive(true);
            fase2Text.text = "Fase 2 Desbloqueada!";
            aviso.text = "Bonus: Quanto mais rapido voce for, mais pontos vai ganhar!";
            fase2Panel.SetActive(true);
        }
    }

    public void Final()
    {
        StopTime = true;
        countText.text = "";
        tl_txt.text = "";
        livesText.text = "";
        fase2Text.text = "";
        aviso.text = "";
        gameOverPanel.SetActive(true);
        if (winTextObject.text == "")
        {
            winTextObject.text = "Voce Perdeu!";
        }
        FinalTime.text = "Tempo Final: " + timeLevel.ToString("0") + " segundos";
        quitButton.SetActive(true);
    }

    void UpdateLivesText()
    {
        livesText.text = lives + "/3";
    }
}
