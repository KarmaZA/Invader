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
        InvokeRepeating("Spawn", 0f, 5f);
    }

    void Spawn()
    {
        if (SpawnEnabled)
        {
            UnityEngine.Vector2 moSp;
            moSp.x = cam.transform.position.x + xOffset;
            moSp.y = Random.Range(-10, 10);
            GameObject enem = Instantiate(enemy, moSp, UnityEngine.Quaternion.identity);
            Destroy(enem, 10f);
        }
    }
    
}
