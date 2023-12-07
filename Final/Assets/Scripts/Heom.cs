using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heom : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 2;
    public Vector3 velocity;

    public IssacMovement player;


    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 3);
        Debug.Log("Shot is Gone");
    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        transform.Translate(transform.forward * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
           




            Destroy(other.gameObject);
            Destroy(gameObject);


        }
        Debug.Log("Enemy hit by Heom");

    }
}
