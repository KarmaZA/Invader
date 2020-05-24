using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform player;
    public Vector2 LookDir;
    public Rigidbody2D rb;
    public float moveSpeed = 5f;

    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        // Vector2 LookDir;

        LookDir.x = player.position.x - rb.position.x;
        LookDir.y = player.position.y - rb.position.y;

       /* float angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg; //+ 90f;
        rb.rotation = angle;*/
    }
    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


        LookDir.Normalize();
        MoveChar(LookDir);
        Debug.Log(player.position);

    }

    void MoveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.fixedDeltaTime));
    }
}
