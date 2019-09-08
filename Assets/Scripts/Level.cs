using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int blocks; // serialized for debugging purposes

    // cached reference
    SceneLoader sceneLoader;
    GameSession gameStatus;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        gameStatus = FindObjectOfType<GameSession>();
    }

    public void CountBlocks()
    {
        blocks++;
    }

    public void BlockDestroyed()
    {
        blocks--;
        gameStatus.AddToScore();
        if (blocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
