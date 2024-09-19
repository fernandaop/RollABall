using UnityEngine;

public class HorizontalMover : MonoBehaviour
{
    public float speed = 10f; // Velocidade de movimento
    public float range = 19f; // Amplitude total do movimento

    private float startX;
    void Start()
    {
        // Armazena a posição inicial do objeto
        startX = transform.position.x;
    }

    void Update()
    {
        // Calcula a nova posição baseada na velocidade e no tempo
        float movement = Mathf.PingPong(Time.time * speed, range);

        // Define a posição do objeto, alternando entre os extremos da faixa
        transform.position = new Vector3(startX + movement - (range / 2), transform.position.y, transform.position.z);
    }
}
