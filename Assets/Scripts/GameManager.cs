using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoretext;
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;

        scoretext.text = "Score: " + score;
    }

    // Update is called once per frame
    public void AddScore(int amount)
    {
        score = score + amount;

        scoretext.text = "Score: " + score;
    }

   
}
