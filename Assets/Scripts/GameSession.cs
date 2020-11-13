using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [Header("General Settings")]
    public int health;
    private int score;
    public int goal = 20;

    [Header("UI Settings")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI goalText;

    [Header("Hero Animation")]
    public Animator heroAnimator;

    void Start()
    {
        healthText.text = health.ToString();
        goalText.text = score.ToString();
    }

    public void ReduceHealth(int amount)
    {
        health -= amount;
        healthText.text = health.ToString();
        heroAnimator.SetTrigger("HealthDecrease");
        if (health <= 0)
        {
            SceneLoader.LoadLose();
        }
    }

    public void IncreaseGoal(int amount)
    {
        score += amount;
        goalText.text = score.ToString();
        goalText.GetComponent<Animator>().SetTrigger("Hitted");
        heroAnimator.SetTrigger("Destroyed");
        if (score >= goal)
        {
            SceneLoader.LoadWin();
        }
    }
    public void Hitted()
    {
        heroAnimator.SetTrigger("Hitted");
    }
}