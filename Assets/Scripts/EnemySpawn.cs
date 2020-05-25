using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float xOffset = 5f;
    public Camera cam;

    public bool SpawnEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 2f);
    }

    void Spawn()
    {
        if (SpawnEnabled)
        {
            for (int x = 0; x < 2;x++)// (2 * LevelNumTrack.Level); x++)
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
