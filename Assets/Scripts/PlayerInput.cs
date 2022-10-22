using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 2f * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            PlayerMove(0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            PlayerMove(0, -speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            PlayerMove(-speed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            PlayerMove(speed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerJump();
        }
    }

    private void PlayerMove(float x, float z)
    {
        player.transform.position = new Vector3(player.transform.position.x + x, player.transform.position.y, player.transform.position.z + z);
    }

    private void PlayerJump()
    {
        player.AddForce(player.velocity.x, 250f, player.velocity.z);
    }
}
