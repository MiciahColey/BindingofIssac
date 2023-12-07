using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float speed;
    private float dist;
    private float distMin = -3f;
    private float distMax = 3f;
    private Vector3 temp;

    public bool goingLeft = true;



    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }

    private void EnemyRoam()
    {
        dist = Random.Range(distMin, distMax);
    }

    private void EnemyMovement()
    {

        if (goingLeft)
        {
            if (transform.position.x >= -dist)
            {
                temp = Vector3.left;
                EnemyRoam();
                goingLeft = false;
            }
        }
        else
        {
            if (transform.position.x <= dist)
            {
                temp = Vector3.right;
                EnemyRoam();
                goingLeft = true;
            }
        }
        transform.position += temp * Time.deltaTime * speed;
    }

}
