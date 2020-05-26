using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float xOffset = 5f;
    public Camera cam;
    public static float EnemyNum;

    public bool SpawnEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        EnemyNum += 2;
        //Debug.Log(EnemyNum + "here");
        Invoke("Spawn", 0f);
    }

    void Spawn()
    {
        if (SpawnEnabled)
        {
            for (int x = 0; x < EnemyNum;x++)// (2 * LevelNumTrack.Level); x++)
                {
                UnityEngine.Vector2 moSp;
                moSp.x = cam.transform.position.x + xOffset;
                moSp.y = Random.Range(-5, 5);
                GameObject enem = Instantiate(enemy, moSp, UnityEngine.Quaternion.identity);
                enem.SetActive(true);
                //Destroy(enem, 4f);
            }
           // LevelNumTrack.Level = LevelNumTrack.Level + 1;
        }
    }
    
}
