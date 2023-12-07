using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brimstone : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 3;
    public Vector3 velocity;


    public IssacMovement player;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        Debug.Log("Shot is Gone");
    }

    // Update is called once per frame
    void Update()
    {

        velocity = direction * speed;
    }


    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Destroy(other.gameObject);
            


        }
        Debug.Log("Enemy hit by Brim");
    }
}
