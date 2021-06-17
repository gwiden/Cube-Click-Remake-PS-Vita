using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubefloat : MonoBehaviour {

    public float speed, tilt;
    private Vector3 target = new Vector3 (0, 2.5f, 0);

    private void Update ()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

        if (transform.position == target && target.y != 0.0f)
        {
            target.y = 0.0f;
        }  
        else if (transform.position == target && target.y == 0.0f)
        {
            target.y = 2.5f;
        }
            

        transform.Rotate(Vector3.up * tilt);
    }
}
