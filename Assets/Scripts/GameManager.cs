﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static float enemyNum = 2f;
    public float enemiesKilled = 0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyNum = 3;//LevelNumTrack.Level * 2;
    }

    // Update is called once per frame
    void Update()
    {
        if ((enemiesKilled > enemyNum))// || (enemiesKilled == 2 && (FindObjectOfType<Enemy>() != null)))
        {
            int sceneNum = SceneManager.GetActiveScene().buildIndex;
            if(sceneNum == 2) // 2 because the are only 2 level so far
            {
                sceneNum = 1;
            } else
            {
                sceneNum += 1;
            }

            enemyNum += 2;
            SceneManager.LoadScene(sceneNum);
        }
    }

    public void KillEnemy()
    {
        //Debug.Log(enemiesKilled);
        enemiesKilled += 1;
    }
}
