using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    private Vector3 direction;

    public float speed;

    [SerializeField]
    private int playerScore;
    [SerializeField]
    private int aiScore;

    public Vector3 spawnPoint;

    public Text playerText;
    public Text aiText;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        aiScore = 0;
        float x_move = Random.Range(0, 2) == 0 ? -1 : 1;
        float z_move = Random.Range(0, 2) == 0 ? -1 : 1;
        this.direction = new Vector3(x_move, 0f, z_move);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += direction * speed;

        if (playerScore == 10)
        {
            SceneManager.LoadScene("Winner");
        }
        else if (aiScore == 10)
        {
            SceneManager.LoadScene("Loser");
        }

    }

    void OnCollisionEnter(Collision col)
    {
        Vector3 normal = col.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
    }

    void OnTriggerEnter(Collider trigger)
    { 
        if (trigger.gameObject.name == "WallTop")
        {
            playerScore++;
            playerText.text = "Player " + playerScore.ToString();
            transform.position = spawnPoint;
        }

        if (trigger.gameObject.name == "WallBottom")
        {
            aiScore++;
            aiText.text = aiScore.ToString() + " AI";
            transform.position = spawnPoint;
        }
    }
}
