using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_movement : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;


    private void Start()
    {
        GameObject.Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }
}


