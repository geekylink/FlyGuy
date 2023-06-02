using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    double acceleration = 0;
    const double ACCELERATION_SPEED = 0.00025;
    const double JUMP_SPEED = 0.025;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);

        /*Vector2 position = transform.position;
        position.x = -5.0f;
        transform.position = position;*/
    }

    void Loser() {
        Debug.Log("loser");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.y = position.y - (float)acceleration;
        acceleration += ACCELERATION_SPEED;


        if (Input.GetKeyDown("space")) {
            acceleration = -JUMP_SPEED;
        }

        // Upper limit
        if (position.y > 4.5f) {
            position.y = 4.5f;
            acceleration = 0;
        }

        // Lower limit - lose
        if (position.y < -5.7f) {
            Loser();
            position.x = 0.0f;
            position.y = 4.5f;
            acceleration = 0;
        }

        // off the screen - lose
        if (position.x < -10.5f) {
            Loser();
            position.x = 0.0f;
            position.y = 4.5f;
            acceleration = 0;
        }

        transform.position = position;
    }
}
