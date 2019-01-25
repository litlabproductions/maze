using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementEngine : MonoBehaviour
{
    private Rigidbody2D engineRB;


    public PlayerController playerController;
    public float speedIncTimer;
    public float speed;
    public float maxSpeed;
    public float speedIncrement;


    private Scene currentScene;
    private string sceneName;

    // Use this for initialization
    void Start ()
    {
        engineRB = GetComponent<Rigidbody2D>();


        engineRB.velocity = new Vector2(0.0f, 1.0f);


        // Create a temporary reference to the current scene.
        currentScene = SceneManager.GetActiveScene();
        // Retrieve the name of this scene.
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneName == "GameScene")
        { 
            if (!playerController.IsPlayerDead())
            {
                speedIncTimer -= Time.deltaTime;

                if (speedIncTimer <= 0 && speed < maxSpeed)
                {
                    speed += speedIncrement;
                    speedIncTimer = 3.0f;
                }

                engineRB.velocity = new Vector2(0.0f, speed);
            }
            else
            {
                speed = 0.0f;
                engineRB.velocity = new Vector2(0.0f, speed);
            }
        }
    }
}
