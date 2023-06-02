using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadDistros : MonoBehaviour
{

    const double SPEED = 0.05;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x - (float)SPEED;

        if (position.x < -20) {
            position.x = 20;
            position.y = Random.Range(-4.0f, 4.0f);

            float size = Random.Range(0.1f, 0.3f);
            transform.localScale = new Vector3(size, size, size);
        }



        transform.position = position;
    }
}
