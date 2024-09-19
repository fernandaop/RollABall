using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; // Rigidbody do jogador.
    private int count; // Contador de objetos coletados.
    private int count2; // Contador de objetos coletados fase 2.
    private float movementX;
    private float movementY;

    public float speed = 0; // Velocidade do jogador.
    private float lastCollisionTime = 0f; // Tempo da última colisão.
    private float collisionCooldown = 1f; // Intervalo de 1 segundo entre colisões.

    //texts
    public TextMeshProUGUI countText; // Texto da contagem.
    public TextMeshProUGUI winTextObject; // Texto de vitória.
    public TextMeshProUGUI tl_txt; // Texto do tempo atual.
    public TextMeshProUGUI FinalTime; // Texto do tempo final.
    public TextMeshProUGUI FinalCount; // Texto da pontuação final.
    public TextMeshProUGUI extraPointsText; // Texto para mostrar o bônus extra.
    public TextMeshProUGUI livesText; // Texto para mostrar a quantidade de vidas restantes.

    //Panel gameover
    public GameObject gameOverPanel;

    
    //botoes quit
    public GameObject quitButton;

    private float timeLevel; // Tempo do nível.
    private int lives = 3; // Número inicial de vidas.
    public static bool StopTime; // Flag para parar o tempo.

    // Start is called before the first frame update.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameOverPanel.SetActive(false);
        count = 12;
        count2 = 0;
        timeLevel = 0f; 
        StopTime = false; 
        countText.text = "Pontos: 12";  // Exibir a pontuação da fase anterior.
        winTextObject.text = "";
        FinalTime.text = "";
        FinalCount.text = "";
        tl_txt.text = "Tempo: 0s";
        extraPointsText.text = "Extra: +0"; 
        livesText.text = lives + "/3"; 
        quitButton.SetActive(false);
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
            extraPointsText.text = "Extra: +" + CalculateBonusPoints().ToString();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            count2 = count2 + 1;
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
        if (count2 >= 12)
        {
            winTextObject.text = "Voce Venceu!";
            int finalPoints = CalculateBonusPoints() + count;
            FinalCount.text = "Pontos: " + finalPoints.ToString();
            StopTime = true;
            Final();
        }
    }

    public void Final()
    {
        StopTime = true;
        countText.text = "";
        tl_txt.text = "";
        extraPointsText.text = "";
        livesText.text = "";
        gameOverPanel.SetActive(true);
        if (winTextObject.text == "" && count < 12)
        {
          winTextObject.text = "Voce Perdeu!";
        }
        FinalTime.text = "Tempo Final: " + timeLevel.ToString("0") + " segundos";
        quitButton.SetActive(true);
    }
    
    int CalculateBonusPoints()
    {
        if (timeLevel <= 15)
            return 15;
        else if (timeLevel <= 25)
            return 12;
        else if (timeLevel <= 35)
            return 10;
        else if (timeLevel <= 45)
            return 7;
        else if (timeLevel <= 55)
            return 5;
        else if (timeLevel <= 60)
            return 3;
        else
            return 0;
    }

    void UpdateLivesText()
    {
        livesText.text = lives + "/3";
    }
}
