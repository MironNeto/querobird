using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public GameController controller;

    private void Start()
    {
        controller = FindAnyObjectByType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
