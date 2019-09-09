using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minXInUnits = 1f;
    [SerializeField] float maxXInUnits = 15f;

    GameSession gameSession;
    Ball ball;

    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePosition = new Vector2(Mathf.Clamp(GetXPos(), minXInUnits, maxXInUnits), transform.position.y);
        this.transform.position = paddlePosition;
    }

    private float GetXPos()
    {
        if (gameSession.IsAutoplayEnabled())
        {
            return ball.transform.position.x;
        }

        return Input.mousePosition.x / Screen.width * screenWidthInUnits;
    }
}
