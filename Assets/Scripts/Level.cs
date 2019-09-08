using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // serialized for debugging purposes

    // cached reference
    SceneLoader sceneLoader;
    GameStatus gameStatus;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        gameStatus = FindObjectOfType<GameStatus>();
    }

    public void CountBreakableBlock()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        gameStatus.AddToScore();
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
