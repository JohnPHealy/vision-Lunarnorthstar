using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Collider2D playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    [SerializeField] private int BonustoGive = 1;
    [SerializeField] private bool IsEnemy;

    private void Update()
    {
        if (playerCheck.IsTouchingLayers(playerLayers))
        {
            manager.AddScore(BonustoGive);
            
            if (IsEnemy == false)
            {
                manager.PowerupRed();
                Destroy(gameObject);
            }
            if (IsEnemy == true)
            {
                manager.RespawnPlayer();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.RespawnPlayer();
        }
    }
}