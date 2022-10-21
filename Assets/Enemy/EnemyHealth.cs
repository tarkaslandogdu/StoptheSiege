using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 5;
    int currentHitPoint = 0;

    void OnEnable()
    {
        currentHitPoint = maxHitPoint;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        
    }
    void ProcessHit()
    {
        currentHitPoint--;
        if (currentHitPoint <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
