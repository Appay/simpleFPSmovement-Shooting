﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health;

    void Update()
    {
        if (health <=0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

}

