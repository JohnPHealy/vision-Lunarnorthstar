using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> CountRed;
    [SerializeField] private UnityEvent<string> CountBlue;
    [SerializeField] private UnityEvent<string> CountYellow;
    private Vector3 startPos;
    private int score;
    private int Redcount;
    private int Bluecount;
    private int Yellowcount;

    private void Start()
    {
        startPos = player.transform.position;
        score = 0;
        UpdateUI();
        //PauseGame();

    }

    public void RespawnPlayer()
    {
        player.transform.position = startPos;
        score = 0;
        UpdateUI();
    }

    public void AddScore(int scoreAmt)
    {
        score += scoreAmt;
        UpdateUI();
    }

    public void CountUpRed(int countAmtR)
    {
        Redcount = countAmtR /2;
        UpdateUI();
    }
    public void CountUpBlue(int countAmtB)
    {
        Bluecount = countAmtB /2;
        UpdateUI();
    }
    public void CountUpYellow(int countAmtY)
    {
        Yellowcount = countAmtY /2;
        UpdateUI();
    }
   

    private void UpdateUI()
    {
        CountRed.Invoke(Redcount.ToString());
        CountBlue.Invoke(Bluecount.ToString());
        CountYellow.Invoke(Yellowcount.ToString());
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

}