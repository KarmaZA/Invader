﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag =="Bullet")
        {
            Destroy(this, 0f);
            Debug.Log("dead");
        }

    }
}
